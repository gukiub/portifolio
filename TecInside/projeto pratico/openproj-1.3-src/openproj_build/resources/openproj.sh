#!/bin/bash
#
#The contents of this file are subject to the Common Public Attribution License
#Version 1.0 (the "License"); you may not use this file except in compliance with
#the License. You may obtain a copy of the License at
#http://www.projity.com/license . The License is based on the Mozilla Public
#License Version 1.1 but Sections 14 and 15 have been added to cover use of
#software over a computer network and provide for limited attribution for the
#Original Developer. In addition, Exhibit A has been modified to be consistent
#with Exhibit B.
#
#Software distributed under the License is distributed on an "AS IS" basis,
#WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the
#specific language governing rights and limitations under the License. The
#Original Code is OpenProj. The Original Developer is the Initial Developer and
#is Projity, Inc. All portions of the code written by Projity are Copyright (c)
#2006, 2007. All Rights Reserved. Contributors Projity, Inc.
#
#Alternatively, the contents of this file may be used under the terms of the
#Projity End-User License Agreeement (the Projity License), in which case the
#provisions of the Projity License are applicable instead of those above. If you
#wish to allow use of your version of this file only under the terms of the
#Projity License and not to allow others to use your version of this file under
#the CPAL, indicate your decision by deleting the provisions above and replace
#them with the notice and other provisions required by the Projity  License. If
#you do not delete the provisions above, a recipient may use your version of this
#file under either the CPAL or the Projity License.
#
#[NOTE: The text of this license may differ slightly from the text of the notices
#in Exhibits A and B of the license at http://www.projity.com/license. You should
#use the latest text at http://www.projity.com/license for your modifications.
#You may not remove this license text from the source files.]
#
#Attribution Information: Attribution Copyright Notice: Copyright (c) 2006, 2007
#Projity, Inc. Attribution Phrase (not exceeding 10 words): Powered by OpenProj,
#an open source solution from Projity. Attribution URL: http://www.projity.com
#Graphic Image as provided in the Covered Code as file:  openproj_logo.png with
#alternatives listed on http://www.projity.com/logo
#
#Display of Attribution Information is required in Larger Works which are defined
#in the CPAL as a work which combines Covered Code or portions thereof with code
#not governed by the terms of the CPAL. However, in addition to the other notice
#obligations, all copies of the Covered Code in Executable and Source Code form
#distributed must, as a form of attribution of the original author, include on
#each user interface screen the "OpenProj" logo visible to all users.  The
#OpenProj logo should be located horizontally aligned with the menu bar and left
#justified on the top left of the screen adjacent to the File menu.  The logo
#must be at least 100 x 25 pixels.  When users click on the "OpenProj" logo it
#must direct them back to http://www.projity.com.
#

CONF_DIR="$HOME/.openproj"
RUN_CONF="$CONF_DIR/run.conf"
VERSION_FILE="$CONF_DIR/java-version"
JAVA_INSTALL_DIR="/usr/java"
JAVA_INSTALL_DIR_EXE="bin/java"
JAVA_INSTALL_DIR2="/usr/lib/jvm"
JAVA_INSTALL_DIR_EXE2="bin/java"
JAVA_INSTALL_DIR3="/opt/ibm"
JAVA_INSTALL_DIR_EXE3="jre/bin/java"
MIN_JAVA_VERSION="1.5"

#Default conf values
JAVA_EXE="java"
JAVA_OPTS="-Xms128m -Xmx768m"
#OPENPROJ_HOME0="/usr/share/openproj"
OPENPROJ_HOME0=`(dirname $0)`
OPENPROJ_HOME="$OPENPROJ_HOME0"
LOG_LEVEL="DEBUG"
LOG_FILE="/dev/null"
AUTO_CONFIGURATION="1"
ARGS="$@"
JAVA_OK="0"
FIRST_JAVA_WITH_CORRECT_VERSION=""
OS_NAME=`uname`

if [ "x$OS_NAME" = "xSunOS" ]; then
	TAIL_COMMAND="/usr/xpg4/bin/tail"
else
	TAIL_COMMAND="tail"
fi

create_run_conf() {
	echo "#Auto-generated parameters" > "$RUN_CONF"
	echo "AUTO_CONFIGURATION=\"$AUTO_CONFIGURATION\"" >> "$RUN_CONF"
	echo "JAVA_EXE=\"$JAVA_EXE\"" >> "$RUN_CONF"

	if [ "x$OS_NAME" = "xLinux" ]; then
		OS_ID=`lsb_release -i 2> /dev/null | sed "s/.*:[ \t]*\(.*\)/\1/"`
		OS_RELEASE=`lsb_release -r 2> /dev/null | sed "s/.*:[ \t]*\(.*\)/\1/"`
	else
		#OS_ID=`uname -v`
		OS_RELEASE=`uname -r`
	fi
	echo "OS_NAME=\"$OS_NAME\"" >> "$RUN_CONF"
	echo "OS_ID=\"$OS_ID\"" >> "$RUN_CONF"
	echo "OS_RELEASE=\"$OS_RELEASE\"" >> "$RUN_CONF"

	if [ "x$OS_ID" = "xSUSE LINUX" ]; then
		#fix broken prefs on SLED10/IBM
		JAVA_OPTS="$JAVA_OPTS -Djava.util.prefs.userRoot=$HOME/.java/.userPrefs -Djava.util.prefs.systemRoot=$HOME/.openproj"
	fi
	echo "JAVA_OPTS=\"$JAVA_OPTS\"" >> "$RUN_CONF"

	#echo "OPENPROJ_HOME=\"$OPENPROJ_HOME\"" >> "$RUN_CONF"
	echo "LOG_LEVEL=\"$LOG_LEVEL\"" >> "$RUN_CONF"
	echo "LOG_FILE=\"$LOG_FILE\"" >> "$RUN_CONF"
}

check_java() {
	JAVA_EXE="$1"
	echo "Checking $JAVA_EXE"

	"$JAVA_EXE" -version > "$VERSION_FILE" 2>&1 || rm -f "$VERSION_FILE"

	if [ -r "$VERSION_FILE" ]; then
		JAVA_VERSION=`cat "$VERSION_FILE" | head -n 1 | awk '{ print substr($3, 2, length($3)-2); }'`
		if [ "x$OS_NAME" = "xSunOS" ]; then
			echo "    Java version: $JAVA_VERSION \c"
		else
			echo -n "    Java version: $JAVA_VERSION "
		fi


		#Comparable format
		MIN_JAVA_VERSION=`echo "$MIN_JAVA_VERSION" | sed -e 's;\.;0;g'`
		JAVA_VERSION=`echo "$JAVA_VERSION" | awk '{ print substr($1, 1, 3); }' | sed -e 's;\.;0;g'`

		if [ "$JAVA_VERSION" ]; then
			if [ "$JAVA_VERSION" -ge "$MIN_JAVA_VERSION" ];	then
				echo "OK"
				JAVA_IMPL=`cat "$VERSION_FILE" | head -n 2 | "$TAIL_COMMAND" -n 1 | awk '{ print $1; }'`
				if [ "x$OS_NAME" = "xSunOS" ]; then
					echo "    Java implementation: $JAVA_IMPL \c"
				else
					echo -n "    Java implementation: $JAVA_IMPL "
				fi
				if [ "x$FIRST_JAVA_WITH_CORRECT_VERSION" = "x" ]; then
					FIRST_JAVA_WITH_CORRECT_VERSION="$JAVA_EXE"
				fi
				if [ "x$JAVA_IMPL" = "xJava(TM)" ] || [ "x$JAVA_IMPL" = "xIcedTea" ]; then
					echo "OK"
					create_run_conf
					JAVA_OK="1"
				else
					echo "NOK, OpenProj requires Sun, IBM or IcedTea implementation"
				fi
			else
				echo "NOK, version < 1.5"
			fi
		else
			echo "NOK"
		fi
	else
		echo "    Error"
	fi
}

run_openproj() {
	if [ "$LOG_LEVEL" ] && [ "x$LOG_LEVEL" = "xDEBUG" ]; then
		"$JAVA_EXE" $JAVA_OPTS -jar "$OPENPROJ_HOME/openproj.jar" $ARGS > "$LOG_FILE"
	else
		"$JAVA_EXE" $JAVA_OPTS -jar "$OPENPROJ_HOME/openproj.jar" $ARGS > /dev/null 2>&1
	fi
}


if [ ! -d "$CONF_DIR" ]; then
	mkdir "$CONF_DIR"
	OS_ID=`lsb_release -i 2> /dev/null | sed "s/.*:[ \t]*\(.*\)/\1/"`
	if [ "x$OS_ID" = "xSUSE LINUX" ]; then
		#fix broken prefs on SLED10/IBM
		mkdir "$CONF_DIR/.systemPrefs"
	fi
fi


if [ -f "$RUN_CONF" ]; then
	. "$RUN_CONF"
	OPENPROJ_HOME="$OPENPROJ_HOME0"
	#OPENPROJ_HOME can be harmful with multiple versions. disable
	JAVA_OK="1"
	ARGS0="$ARGS"
	ARGS="--silentlyFail true $ARGS"
	run_openproj || if [[ $? -eq 126 || $? -eq 127 || $? -eq 64 ]]; then
		#126 command invoked cannot execute
		#127 command not found
		#64 bad java version/impl
		if [ "x$AUTO_CONFIGURATION" != "x0" ]; then
			JAVA_OK="0"
			#auto-detection will be performed
		fi
	fi
	ARGS="$ARGS0"
fi

if [ "$JAVA_OK" -eq "0" ]; then
	echo "Java auto-detection..."

	if [ "$JAVA_HOME" ] && [ -x "$JAVA_HOME/bin/java" ]; then
		check_java "$JAVA_HOME/bin/java"
	fi

	if [ "$JAVA_OK" -eq "0" ]; then
		check_java "java"
	fi

	#search in $JAVA_INSTALL_DIR
	if [ "$JAVA_OK" -eq "0" ] && [ -d "$JAVA_INSTALL_DIR" ]; then
		J="$JAVA_INSTALL_DIR/latest/$JAVA_INSTALL_DIR_EXE"
		if [ -x "$J" ]; then
			check_java "$J"
		fi
		if [ "$JAVA_OK" -eq "0" ]; then
			J="$JAVA_INSTALL_DIR/default/$JAVA_INSTALL_DIR_EXE"
			if [ -x "$J" ]; then
				check_java "$J"
			fi
		fi
		if [ "$JAVA_OK" -eq "0" ]; then
			for i in $JAVA_INSTALL_DIR/* ; do
				J="$i/$JAVA_INSTALL_DIR_EXE"
				if [ "$J" = "$JAVA_INSTALL_DIR/latest" ] || [ "$J" = "$JAVA_INSTALL_DIR/default" ]; then
					#already checked
					continue
				fi
				if [ -x "$J" ]; then
					check_java "$J"
					if [ "$JAVA_OK" -eq "1" ]; then
						break
					fi
				fi
			done
		fi
	fi

	JAVA_INSTALL_DIR="$JAVA_INSTALL_DIR2"
	JAVA_INSTALL_DIR_EXE="$JAVA_INSTALL_DIR_EXE2"

	#search in $JAVA_INSTALL_DIR
	if [ "$JAVA_OK" -eq "0" ] && [ -d "$JAVA_INSTALL_DIR" ]; then
		J="$JAVA_INSTALL_DIR/latest/$JAVA_INSTALL_DIR_EXE"
		if [ -x "$J" ]; then
			check_java "$J"
		fi
		if [ "$JAVA_OK" -eq "0" ]; then
			J="$JAVA_INSTALL_DIR/default/$JAVA_INSTALL_DIR_EXE"
			if [ -x "$J" ]; then
				check_java "$J"
			fi
		fi
		if [ "$JAVA_OK" -eq "0" ]; then
			for i in $JAVA_INSTALL_DIR/* ; do
				J="$i/$JAVA_INSTALL_DIR_EXE"
				if [ "$J" = "$JAVA_INSTALL_DIR/latest" ] || [ "$J" = "$JAVA_INSTALL_DIR/default" ]; then
					#already checked
					continue
				fi
				if [ -x "$J" ]; then
					check_java "$J"
					if [ "$JAVA_OK" -eq "1" ]; then
						break
					fi
				fi
			done
		fi
	fi

	JAVA_INSTALL_DIR="$JAVA_INSTALL_DIR3"
	JAVA_INSTALL_DIR_EXE="$JAVA_INSTALL_DIR_EXE3"

	#search in $JAVA_INSTALL_DIR
	if [ "$JAVA_OK" -eq "0" ] && [ -d "$JAVA_INSTALL_DIR" ]; then
		J="$JAVA_INSTALL_DIR/latest/$JAVA_INSTALL_DIR_EXE"
		if [ -x "$J" ]; then
			check_java "$J"
		fi
		if [ "$JAVA_OK" -eq "0" ]; then
			J="$JAVA_INSTALL_DIR/default/$JAVA_INSTALL_DIR_EXE"
			if [ -x "$J" ]; then
				check_java "$J"
			fi
		fi
		if [ "$JAVA_OK" -eq "0" ]; then
			for i in $JAVA_INSTALL_DIR/* ; do
				J="$i/$JAVA_INSTALL_DIR_EXE"
				if [ "$J" = "$JAVA_INSTALL_DIR/latest" ] || [ "$J" = "$JAVA_INSTALL_DIR/default" ]; then
					#already checked
					continue
				fi
				if [ -x "$J" ]; then
					check_java "$J"
					if [ "$JAVA_OK" -eq "1" ]; then
						break
					fi
				fi
			done
		fi
	fi


	if [ "$JAVA_OK" -eq "0" ]; then
		echo "Java not found or incorrect version."
		echo "Please install Sun, IBM or IcedTea JRE 1.5+ or set JAVA_HOME environment variable if it's already installed."
	else
		echo "Java OK"
	fi

	if [ "$JAVA_OK" -eq "1" ]; then
		run_openproj
	else
		if [ "x$FIRST_JAVA_WITH_CORRECT_VERSION" != "x" ]; then
			echo "Trying $FIRST_JAVA_WITH_CORRECT_VERSION ..."
			JAVA_EXE="$FIRST_JAVA_WITH_CORRECT_VERSION"
			create_run_conf
			run_openproj
			echo $?
		fi
	fi


fi

