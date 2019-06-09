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

Attribution Information: Attribution Copyright Notice: Copyright � 2006, 2007 
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
package com.projity.pm.calendar;

import java.io.Serializable;

import com.projity.strings.Messages;

public class WorkWeek implements Cloneable,Serializable {
	static final long serialVersionUID = 2555674567677L;
    public static final int DAYS_IN_WEEK = 7;
	public static final long MS_IN_WEEK = DAYS_IN_WEEK * 24L*60*60*1000;
    WorkDay workDay[] = new WorkDay[DAYS_IN_WEEK];

    private static String WEEKDAY_MASK = new String(Messages.getString("Calendar.WeekdayBitMaskFromSundayToSaturday"));
	/* (non-Javadoc)
	 * @see java.lang.Object#clone()
	 */
	public Object clone() {
		WorkWeek newOne = new WorkWeek();
		for (int i = 0; i < DAYS_IN_WEEK; i++) {
			if (workDay[i] == null)
				newOne.workDay[i] = null;
			else
				newOne.workDay[i] = (WorkDay) workDay[i].clone();
		}
		return newOne;
	}

	public WorkWeek(WorkDay[] days) {
		this.workDay = (WorkDay[]) days.clone();
        updateWorkingDuration();
	}
	
    public WorkWeek() {
        for (int i = 0; i < DAYS_IN_WEEK; i++)
            workDay[i] = null;
    }
    public WorkDay getWeekDay(int dayNum) {
//    	if (dayNum < 0)
//    		System.out.println("day num is " + dayNum);    	
    	return workDay[dayNum];
    }
    
    WorkWeek intersectWith(WorkWeek other) throws InvalidCalendarIntersectionException {
    	WorkWeek result = new WorkWeek();
        for (int i = 0; i < DAYS_IN_WEEK; i++)
            result.workDay[i] = workDay[i].intersectWith(other.getWeekDay(i));
        result.updateWorkingDuration();
        if (result.getDuration() == 0) // a calendar cannot have no working time for its work week
        	throw new InvalidCalendarIntersectionException();
        return result;
    	
    }
    public void setWeekDay(int dayNum, WorkDay day) {
    	if (day != null)
    		day.initialize();
    	workDay[dayNum] = day;
        updateWorkingDuration();    	
    }
    
    public void setWeekDays(WorkDay day) {
    	for (int i = 0; i < DAYS_IN_WEEK; i++) {
    		if (WEEKDAY_MASK.charAt(i) == '1') {
    			setWeekDay(i,day);
    		}
    	}
        updateWorkingDuration();    	
    }
    public void setWeekends(WorkDay day) {
    	for (int i = 0; i < DAYS_IN_WEEK; i++) {
    		if (WEEKDAY_MASK.charAt(i) == '0') {
    			setWeekDay(i,day);
    		}
    	}
        updateWorkingDuration();    	
    }
    
    public void addDaysFrom(WorkWeek from) {
        for (int i = 0; i < DAYS_IN_WEEK; i++) {
        	if (from.workDay[i] != null)
        		workDay[i] = from.workDay[i];
        		workDay[i].initialize(); // calc hours - fixes bug in importing project 2007 files
        }
        updateWorkingDuration();
    }
    
    private long workingDuration = 0;

    void updateWorkingDuration() {
    	workingDuration = 0;
    	for (int i = 0; i < DAYS_IN_WEEK; i++) {
    		if (workDay[i] != null)
    			workingDuration += workDay[i].getDuration();
    	}
    }

    public final long getDuration() {
    	return workingDuration;
    }
}
