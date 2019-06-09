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
package com.projity.server.data;

import com.projity.pm.key.uniqueid.UniqueIdException;
import com.projity.session.SessionFactory;


/**
 * preserialization to avoid deserialization followed by serialization on server
 *
 */
public class SerializedDataObject extends CommonDataObject {
	static final long serialVersionUID = 16280304846919L;

	public final static int UPDATE=1;
	public final static int MOVE=2;
//	public final static int INSERT=3;
//	public final static int MOVE=4;
//	public final static int REMOVE=8;
	protected int status;


    protected byte[] serialized;


    public byte[] getSerialized() {
        return serialized;
    }
    public void setSerialized(byte[] serialized) {
        this.serialized = serialized;
    }

	public int getStatus() {
		return status;
	}
	public void setStatus(int status) {
		this.status = status;
	}

	public void emtpy(){
		serialized=null;
		name=null;
		status=0;
	}


    public int getType(){
        return 0;
    }

    public String getPrefix(){
    	if (getType()==DataObjectConstants.COMPANY_TYPE) return "Company";
    	else if (getType()==DataObjectConstants.CALENDAR_TYPE) return "Calendar";
    	else if (getType()==DataObjectConstants.PROJECT_TYPE) return "Project";
    	else if (getType()==DataObjectConstants.ENTERPRISE_RESOURCE_TYPE) return "EnterpriseResource";
    	else if (getType()==DataObjectConstants.RESOURCE_TYPE) return "Resource";
    	else if (getType()==DataObjectConstants.TASK_TYPE) return "Task";
    	else if (getType()==DataObjectConstants.ASSIGNMENT_TYPE) return "Assignment";
    	else if (getType()==DataObjectConstants.LINK_TYPE) return "Link";
    	else if (getType()==DataObjectConstants.BANKING_INFO_TYPE) return "BankingInfo";
    	else if (getType()==DataObjectConstants.CREDIT_CARD_BANKING_INFO_TYPE) return "CreditCardBankingInfo";
    	else if (getType()==DataObjectConstants.CHECK_BANKING_INFO_TYPE) return "CheckBankingInfo";
       	else if (getType()==DataObjectConstants.USER_TYPE) return "User";
       	else if (getType()==DataObjectConstants.PARTNER_USER_TYPE) return "PartnerUser";
       	else if (getType()==DataObjectConstants.PARTNER_COMPANY_TYPE) return "PartnerCompany";

    	else return "Unknown";
    }

	/*private void writeObject(ObjectOutputStream s) throws IOException {
		System.out.println("Serializing "+getType()+", "+getUniqueId()+"...");
	    s.defaultWriteObject();
		System.out.println("Serializing "+getType()+", "+getUniqueId()+" Done");
	}
	private void readObject(ObjectInputStream s) throws IOException, ClassNotFoundException  {
		System.out.println("Deserializing "+getType()+", "+getUniqueId()+"...");
	    s.defaultReadObject();
		System.out.println("Deserializing "+getType()+", "+getUniqueId()+" Done");
	}*/


	protected long uniqueId=-1L;
    protected String name;
//    protected boolean dirty=true;


//    protected Map details=null;

    public long getUniqueId() {
        return uniqueId;
    }
    public void setUniqueId(long id) {
        this.uniqueId = id;
    }
//	public boolean isNew() {
//		return isNew;
//	}
//	public void setNew(boolean isNew) {
//		this.isNew = isNew;
//	}
    public String getName() {
        return name;
    }
    public void setName(String name) {
        this.name = name;
    }
    public boolean isLocal(){
        return isLocal(this);
    }

    public boolean isDirty() {
		return (status&UPDATE)==UPDATE;
	}
	public void setDirty(boolean dirty) {
		//System.out.println("SerializedDataObject _setDirty("+dirty+"): "+getName());
		if (dirty) status|=UPDATE;
		else status=0;
	}
    public boolean isMoved() {
		return (status&MOVE)==MOVE;
	}
	public void setMoved(boolean moved) {
		if (moved) status|=MOVE;
	}

	public String toString(){
    	return name;//+"("+uniqueId+")";
    }

    public static boolean isLocal(DataObject data){
        return isLocal(data.getUniqueId());
    }
    public static boolean isLocal(long uniqueId){
        return uniqueId<1000000000L;
    }
    public static void makeGlobal(DataObject data) throws UniqueIdException{
    	if (isLocal(data)) data.setUniqueId(SessionFactory.getInstance().getSession(false).getId());
    }

	public boolean isExternal() { // will be true for external tasks
		return false;
	}


}
