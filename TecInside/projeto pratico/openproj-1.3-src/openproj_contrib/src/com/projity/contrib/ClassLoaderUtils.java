/*
The contents of this file are subject to the Common Public Attribution License
Version 1.0 (the "License"); you may not use this file except in compliance with
the License. You may obtain a copy of the License at
http://www.projity.com/license . The License is based on the Mozilla Public
License Version 1.1 but Sections 14 and 15 have been added to cover use of
software over a computer network and provide for limited attribution for the
Original Developer. In addition, Exhibit A has been modified to be consistent
with Exhibit B.

Software distributed under the License is distributed on an "AS IS" basis,
WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the
specific language governing rights and limitations under the License. The
Original Code is OpenProj. The Original Developer is the Initial Developer and
is Projity, Inc. All portions of the code written by Projity are Copyright (c)
2006, 2007. All Rights Reserved. Contributors Projity, Inc.

Alternatively, the contents of this file may be used under the terms of the
Projity End-User License Agreeement (the Projity License), in which case the
provisions of the Projity License are applicable instead of those above. If you
wish to allow use of your version of this file only under the terms of the
Projity License and not to allow others to use your version of this file under
the CPAL, indicate your decision by deleting the provisions above and replace
them with the notice and other provisions required by the Projity  License. If
you do not delete the provisions above, a recipient may use your version of this
file under either the CPAL or the Projity License.

[NOTE: The text of this license may differ slightly from the text of the notices
in Exhibits A and B of the license at http://www.projity.com/license. You should
use the latest text at http://www.projity.com/license for your modifications.
You may not remove this license text from the source files.]

Attribution Information: Attribution Copyright Notice: Copyright 2006, 2007
Projity, Inc. Attribution Phrase (not exceeding 10 words): Powered by OpenProj,
an open source solution from Projity. Attribution URL: http://www.projity.com
Graphic Image as provided in the Covered Code as file:  openproj_logo.png with
alternatives listed on http://www.projity.com/logo

Display of Attribution Information is required in Larger Works which are defined
in the CPAL as a work which combines Covered Code or portions thereof with code
not governed by the terms of the CPAL. However, in addition to the other notice
obligations, all copies of the Covered Code in Executable and Source Code form
distributed must, as a form of attribution of the original author, include on
each user interface screen the "OpenProj" logo visible to all users.  The
OpenProj logo should be located horizontally aligned with the menu bar and left
justified on the top left of the screen adjacent to the File menu.  The logo
must be at least 100 x 25 pixels.  When users click on the "OpenProj" logo it
must direct them back to http://www.projity.com.
*/

package com.projity.contrib;

import java.lang.reflect.Method;
import java.util.Locale;
import java.util.ResourceBundle;
import java.util.StringTokenizer;

import javax.swing.UIManager;

public class ClassLoaderUtils {
	protected static ClassLoaderTransformer transformer;

	public static ClassLoaderTransformer getTransformer() {
		return transformer;
	}

	public static void setTransformer(ClassLoaderTransformer transformer) {
		ClassLoaderUtils.transformer = transformer;
	}

	public static interface ClassLoaderTransformer{
		public ClassLoader transform(ClassLoader c);
	}

	public static ClassLoader getLocalClassLoader(){
		return getModifiedClassLoader(ClassLoaderUtils.class.getClassLoader());
	}
	public static ClassLoader getModifiedClassLoader(ClassLoader defaultClassLoader){
		if (transformer==null||!needModifiedClassloader()) return defaultClassLoader;
		else return transformer.transform(defaultClassLoader);
	}

	public static ResourceBundle getBundle(String baseName){
		return ResourceBundle.getBundle(baseName,Locale.getDefault(),getLocalClassLoader());
	}

	public static Class forName(String name) throws ClassNotFoundException{
		return Class.forName(name, true, getLocalClassLoader());
	}
	private static Method messageMethod;
	public static String getString(String key) {

		  if (messageMethod == null) {
			  try {
				  Class mess = Class.forName("com.projity.strings.Messages");
				  messageMethod = mess.getMethod("getString", new Class[] {String.class});
			  } catch (Exception e) {
				  e.printStackTrace();
			  }
		  }
		  String value = null;
		  if (messageMethod != null) {
			  try {
				  value = (String) messageMethod.invoke(null, new Object[] {key});
			  } catch (Exception x){
				  x.printStackTrace();
			  }
		  } else {
			  System.out.println("null message method");
		  }
		  if (value == null)
			  value = UIManager.getString(key);
		  return value;
	}



	private static boolean modifClassloader=false;
	private static String javaVersion=null;

	/**
    * Compares this version with the specified version for order.  Returns a
    * negative integer, zero, or a positive integer as this version is less
    * than, equal to, or greater than the specified version.
    */
	public static int compareJavaVersionTo(String version){
		return compareJavaVersion(javaVersion, version);
	}
	public static int compareJavaVersion(String version1,String version2){
		StringTokenizer javaVersionTok1=new StringTokenizer(version1,".");
		StringTokenizer javaVersionTok2=new StringTokenizer(version2,".");
		while (javaVersionTok1.hasMoreTokens() || javaVersionTok2.hasMoreTokens()){
			int v1=-1;
			try {
				v1=javaVersionTok1.hasMoreElements()?Integer.parseInt(javaVersionTok1.nextToken()):0;
			} catch (NumberFormatException e) {}
			int v2=-1;
			try {
				v2=javaVersionTok2.hasMoreElements()?Integer.parseInt(javaVersionTok2.nextToken()):0;
			} catch (NumberFormatException e) {}
			if (v1==0 && v2==-1) return -1;
			else if (v1==-1 && v2==0) return 1;
			if (v1<v2) return -1;
			else if (v1>v2) return 1;
		}
		return 0;
	}
	public static boolean needModifiedClassloader(){
		if (javaVersion==null) getJavaVersion(); //init
		return modifClassloader;
	}

	public static String getJavaVersion(){
		if (javaVersion==null){
			javaVersion=System.getProperty("java.specification.version");
			modifClassloader=compareJavaVersionTo("1.6")<0;
		}
		return javaVersion;
	}
}
