package com.projity.dialog.calendar;

import java.util.Date;

import org.jdesktop.swing.calendar.DateSpan;

import com.projity.pm.time.HasStartAndEnd;

public class CalendarInterval extends DateSpan implements HasStartAndEnd {

	public CalendarInterval(Date start, Date end) {
		super(start, end);
		// TODO Auto-generated constructor stub
	}

	public CalendarInterval(long start, long end) {
		super(start, end);
		// TODO Auto-generated constructor stub
	}

}
