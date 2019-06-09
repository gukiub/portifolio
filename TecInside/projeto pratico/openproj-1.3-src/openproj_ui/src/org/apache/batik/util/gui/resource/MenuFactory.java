/*

 ============================================================================
                   The Apache Software License, Version 1.1
 ============================================================================

 Copyright (C) 1999-2003 The Apache Software Foundation. All rights reserved.

 Redistribution and use in source and binary forms, with or without modifica-
 tion, are permitted provided that the following conditions are met:

 1. Redistributions of  source code must  retain the above copyright  notice,
    this list of conditions and the following disclaimer.

 2. Redistributions in binary form must reproduce the above copyright notice,
    this list of conditions and the following disclaimer in the documentation
    and/or other materials provided with the distribution.

 3. The end-user documentation included with the redistribution, if any, must
    include  the following  acknowledgment:  "This product includes  software
    developed  by the  Apache Software Foundation  (http://www.apache.org/)."
    Alternately, this  acknowledgment may  appear in the software itself,  if
    and wherever such third-party acknowledgments normally appear.

 4. The names "Batik" and  "Apache Software Foundation" must  not  be
    used to  endorse or promote  products derived from  this software without
    prior written permission. For written permission, please contact
    apache@apache.org.

 5. Products  derived from this software may not  be called "Apache", nor may
    "Apache" appear  in their name,  without prior written permission  of the
    Apache Software Foundation.

 THIS SOFTWARE IS PROVIDED ``AS IS'' AND ANY EXPRESSED OR IMPLIED WARRANTIES,
 INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
 FITNESS  FOR A PARTICULAR  PURPOSE ARE  DISCLAIMED.  IN NO  EVENT SHALL  THE
 APACHE SOFTWARE  FOUNDATION  OR ITS CONTRIBUTORS  BE LIABLE FOR  ANY DIRECT,
 INDIRECT, INCIDENTAL, SPECIAL,  EXEMPLARY, OR CONSEQUENTIAL  DAMAGES (INCLU-
 DING, BUT NOT LIMITED TO, PROCUREMENT  OF SUBSTITUTE GOODS OR SERVICES; LOSS
 OF USE, DATA, OR  PROFITS; OR BUSINESS  INTERRUPTION)  HOWEVER CAUSED AND ON
 ANY  THEORY OF LIABILITY,  WHETHER  IN CONTRACT,  STRICT LIABILITY,  OR TORT
 (INCLUDING  NEGLIGENCE OR  OTHERWISE) ARISING IN  ANY WAY OUT OF THE  USE OF
 THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

 This software  consists of voluntary contributions made  by many individuals
 on  behalf of the Apache Software  Foundation. For more  information on the
 Apache Software Foundation, please see <http://www.apache.org/>.

*/

package org.apache.batik.util.gui.resource;

import java.awt.Event;
import java.awt.Point;
import java.awt.event.KeyEvent;
import java.awt.event.MouseEvent;
import java.net.URL;
import java.util.Iterator;
import java.util.List;
import java.util.MissingResourceException;
import java.util.ResourceBundle;

import javax.swing.AbstractButton;
import javax.swing.Action;
import javax.swing.Box;
import javax.swing.ButtonGroup;
import javax.swing.ImageIcon;
import javax.swing.JCheckBoxMenuItem;
import javax.swing.JComponent;
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;
import javax.swing.JPopupMenu;
import javax.swing.JRadioButtonMenuItem;
import javax.swing.JSeparator;
import javax.swing.JToolTip;
import javax.swing.KeyStroke;

import com.projity.menu.ExtButtonFactory;
import com.projity.menu.HyperLinkToolTip;
import com.projity.util.ClassLoaderUtils;

/**
 * This class represents a menu factory which builds
 * menubars and menus from the content of a resource file.<br>
 *
 * The resource entries format is (for a menubar named 'MenuBar'):<br>
 * <pre>
 *   MenuBar           = Menu1 Menu2 ...
 *
 *   Menu1.type        = RADIO | CHECK | MENU | ITEM
 *   Menu1             = Item1 Item2 - Item3 ...
 *   Menu1.text        = text 
 *   Menu1.icon        = icon_name 
 *   Menu1.mnemonic    = mnemonic 
 *   Menu1.accelerator = accelerator
 *   Menu1.action      = action_name
 *   Menu1.selected    = true | false
 *   Menu1.enabled     = true | false
 *   ...
 * mnemonic is a single character
 * accelerator is of the form: mod+mod+...+X
 *   where mod is Shift, Meta, Alt or Ctrl
 * '-' represents a separator
 * </pre>
 * All entries are optional except the '.type' entry
 * Consecutive RADIO items are put in a ButtonGroup
 *
 * @author <a href="mailto:stephane@hillion.org">Stephane Hillion</a>
 * @version $Id: MenuFactory.java,v 1.1 2007/08/15 23:28:28 suricate Exp $
 */
public class MenuFactory extends ResourceManager {
    // Constants
    //
    private final static String TYPE_MENU          = "MENU";
    private final static String TYPE_ITEM          = "ITEM";
    private final static String TYPE_RADIO         = "RADIO";
    private final static String TYPE_CHECK         = "CHECK";
    private final static String SEPARATOR          = "-";
    private final static String GLUE          = ">";

    private final static String TYPE_SUFFIX        = ".type";
    protected final static String TEXT_SUFFIX        = ".text";
    private final static String MNEMONIC_SUFFIX    = ".mnemonic";
    private final static String ACCELERATOR_SUFFIX = ".accelerator";
    private final static String ACTION_SUFFIX      = ".action";
    private final static String SELECTED_SUFFIX    = ".selected";
    private final static String ENABLED_SUFFIX     = ".enabled";
    private final static String ICON_SUFFIX        = ".icon";

    /**
     * The table which contains the actions
     */
    private ActionMap actions;
	protected ClassLoader classLoader;  //LC MODIF

    /**
     * The current radio group
     */
    private ButtonGroup buttonGroup;

    /**
     * Creates a new menu factory
     * @param rb the resource bundle that contains the menu bar
     *           description.
     * @param am the actions to add to menu items
     */
    public MenuFactory(ResourceBundle rb, ActionMap am) {
        super(rb);
        actions = am;
	buttonGroup = null;
	classLoader=ClassLoaderUtils.getLocalClassLoader(); //LC MODIF
    }

    /**
     * Creates and returns a swing menu bar
     * @param name the name of the menu bar in the resource bundle
     * @throws MissingResourceException if one of the keys that compose the
     *         menu is missing.
     *         It is not thrown if the mnemonic, the accelerator and the
     *         action keys are missing
     * @throws ResourceFormatException if the mnemonic is not a single
     *         character and if the accelerator is malformed
     * @throws MissingListenerException if an item action is not found in the
     *         action map
     */
    public JMenuBar createJMenuBar(String name)
	throws MissingResourceException,
               ResourceFormatException,
	       MissingListenerException {
        JMenuBar result = new JMenuBar();
        List     menus  = getStringList(name);
        Iterator it     = menus.iterator();
        while (it.hasNext()) {
        	String x = (String) it.next();
            result.add(createJMenuComponent(x));
        }
        return result;
    }

    public JPopupMenu createJPopupMenuBar(String name)
	throws MissingResourceException,
               ResourceFormatException,
	       MissingListenerException {
        JPopupMenu result = new JPopupMenu();
        List     menus  = getStringList(name);
        Iterator it     = menus.iterator();
        
        while (it.hasNext()) {
        	String x = (String) it.next();
            result.add(createJMenuComponent(x));
        }
        return result;
    }

    /**
     * Creates and returns a menu item or a separator
     * @param name the name of the menu item or "-" to create a separator
     * @throws MissingResourceException if key is not the name of a menu item.
     *         It is not thrown if the mnemonic, the accelerator and the
     *         action keys are missing
     * @throws ResourceFormatException in case of malformed entry
     * @throws MissingListenerException if an item action is not found in the
     *         action map
     */
    protected JComponent createJMenuComponent(String name)
	throws MissingResourceException,
	       ResourceFormatException,
	       MissingListenerException {
    	if (name.equals(GLUE)) {
    	    buttonGroup = null;
    	    return (JComponent) Box.createHorizontalGlue();
    	}
	if (name.equals(SEPARATOR)) {
	    buttonGroup = null;
	    return new JSeparator();
	}
        String     type = getString(name+TYPE_SUFFIX);
        JComponent item = null;

	if (type.equals(TYPE_RADIO)) {
	    if (buttonGroup == null) {
		buttonGroup = new ButtonGroup();
	    }
	} else {
	    buttonGroup = null;
	}

        if (type.equals(TYPE_MENU)) {
            item = createJMenu(name);
        } else if (type.equals(TYPE_ITEM)) {
            item = createJMenuItem(name);
        } else if (type.equals(TYPE_RADIO)) {
            item = createJRadioButtonMenuItem(name);
	    buttonGroup.add((AbstractButton)item);
        } else if (type.equals(TYPE_CHECK)) {
            item = createJCheckBoxMenuItem(name);
        } else {
	    throw new ResourceFormatException("Malformed resource",
					      bundle.getClass().getName(),
					      name+TYPE_SUFFIX);
	}
	
        return item;
    }

    /**
     * Creates and returns a new swing menu
     * @param name the name of the menu bar in the resource bundle
     * @throws MissingResourceException if one of the keys that compose the
     *         menu is missing.
     *         It is not thrown if the mnemonic, the accelerator and the
     *         action keys are missing
     * @throws ResourceFormatException if the mnemonic is not a single
     *         character.
     * @throws MissingListenerException if a item action is not found in the
     *         action map.
     */
    public JMenu createJMenu(String name)
	throws MissingResourceException,
	       ResourceFormatException,
	       MissingListenerException {
        JMenu result = new JMenu(getString(name+TEXT_SUFFIX)){
			public Point getToolTipLocation(MouseEvent event) { // the tip MUST be touching the button if html because you can click on links
				if (getToolTipText().startsWith("<html>"))
					return new Point(0, getHeight()-2);
				else
					return super.getToolTipLocation(event);
			}

			public JToolTip createToolTip() {
				if (getToolTipText().startsWith("<html>")) {
					JToolTip tip = new HyperLinkToolTip();
					tip.setComponent(this);
					return tip;
				} else {
					return super.createToolTip();
				}
			}
		};
        initializeJMenuItem(result, name);

        List     items = getStringList(name);
        Iterator it    = items.iterator();

        while (it.hasNext()) {
        	String itemName = (String)it.next();
        	
        	JComponent item= createJMenuComponent(itemName);
        	// I added the possibility of having an invisible menu item. This is needed to handle radio button groups that have a "none" option.  Aside from
        	// its initial state, a button group must always have a selected item.  By creating an invisible item, I can essentially select "none" by selecting
        	// the invisible one
			boolean visible = true;
			try {
				visible = getBoolean(itemName + ExtButtonFactory.VISIBLE_SUFFIX);
			} catch (MissingResourceException e) {
			}
			if (visible)
				result.add(item);
        }
        return result;
    }

    /**
     * Creates and returns a new swing menu item
     * @param name the name of the menu item
     * @throws MissingResourceException if one of the keys that compose the
     *         menu item is missing.
     *         It is not thrown if the mnemonic, the accelerator and the
     *         action keys are missing
     * @throws ResourceFormatException if the mnemonic is not a single
     *         character.
     * @throws MissingListenerException if then item action is not found in
     *         the action map.
     */
    public JMenuItem createJMenuItem(String name)
	throws MissingResourceException,
	       ResourceFormatException,
	       MissingListenerException {
        JMenuItem result = new JMenuItem(getString(name+TEXT_SUFFIX));
        initializeJMenuItem(result, name);
        return result;
    }

    /**
     * Creates and returns a new swing radio button menu item
     * @param name the name of the menu item
     * @throws MissingResourceException if one of the keys that compose the
     *         menu item is missing.
     *         It is not thrown if the mnemonic, the accelerator and the
     *         action keys are missing
     * @throws ResourceFormatException if the mnemonic is not a single
     *         character.
     * @throws MissingListenerException if then item action is not found in
     *         the action map.
     */
    public JRadioButtonMenuItem createJRadioButtonMenuItem(String name)
	throws MissingResourceException,
	       ResourceFormatException,
	       MissingListenerException {
        JRadioButtonMenuItem result;
	result = new JRadioButtonMenuItem(getString(name+TEXT_SUFFIX));
        initializeJMenuItem(result, name);

        // is the item selected?
	try {
	    result.setSelected(getBoolean(name+SELECTED_SUFFIX));
	} catch (MissingResourceException e) {
	}
	
        return result;
    }

    /**
     * Creates and returns a new swing check box menu item
     * @param name the name of the menu item
     * @throws MissingResourceException if one of the keys that compose the
     *         menu item is missing.
     *         It is not thrown if the mnemonic, the accelerator and the
     *         action keys are missing
     * @throws ResourceFormatException if the mnemonic is not a single
     *         character.
     * @throws MissingListenerException if then item action is not found in
     *         the action map.
     */
    public JCheckBoxMenuItem createJCheckBoxMenuItem(String name)
	throws MissingResourceException,
	       ResourceFormatException,
	       MissingListenerException {
        JCheckBoxMenuItem result;
        result = new JCheckBoxMenuItem(getString(name+TEXT_SUFFIX));
        initializeJMenuItem(result, name);

        // is the item selected?
	try {
	    result.setSelected(getBoolean(name+SELECTED_SUFFIX));
	} catch (MissingResourceException e) {
	}
	
        return result;
    }

    /**
     * Initializes a swing menu item
     * @param item the menu item to initialize
     * @param name the name of the menu item
     * @throws ResourceFormatException if the mnemonic is not a single
     *         character.
     * @throws MissingListenerException if then item action is not found in
     *         the action map.
     */
    protected void initializeJMenuItem(JMenuItem item, String name)
	throws ResourceFormatException,
	       MissingListenerException {
        // Action
	try {
	    Action a = actions.getAction(getString(name+ACTION_SUFFIX));
	    if (a == null) {
		throw new MissingListenerException("", "Action",
                                                   name+ACTION_SUFFIX);
	    }
	    item.setAction(a);
            item.setText(getString(name+TEXT_SUFFIX));
	    if (a instanceof JComponentModifier) {
		((JComponentModifier)a).addJComponent(item);
	    }
	} catch (MissingResourceException e) {
	}

	// Icon
	try {
	    String s = getString(name+ICON_SUFFIX);
	    URL url  = classLoader.getResource(s);
//	    URL url  = actions.getClass().getResource(s);
	    if (url != null) {
		item.setIcon(new ImageIcon(url));
	    }
	} catch (MissingResourceException e) {
	}

        // Mnemonic
	try {
	    String str = getString(name+MNEMONIC_SUFFIX);
	    if (str.length() == 1) {
		item.setMnemonic(str.charAt(0));
	    } else {
		throw new ResourceFormatException("Malformed mnemonic",
						  bundle.getClass().getName(),
						  name+MNEMONIC_SUFFIX);
	    }
	} catch (MissingResourceException e) {
	}

        // Accelerator
	try {
	    if (!(item instanceof JMenu)) {
		String str = getString(name+ACCELERATOR_SUFFIX);
		KeyStroke ks = toKeyStroke(str);
		if (ks != null) {
		    item.setAccelerator(ks);
		} else {
		    throw new ResourceFormatException
                        ("Malformed accelerator",
                         bundle.getClass().getName(),
                         name+ACCELERATOR_SUFFIX);
		}
	    }
	} catch (MissingResourceException e) {
	}

        // is the item enabled?
	try {
	    item.setEnabled(getBoolean(name+ENABLED_SUFFIX));
	} catch (MissingResourceException e) {
	}
    }

    /**
     * Translate a string into a key stroke.
     * See the class comment for details
     * @param str a string
     */
    protected KeyStroke toKeyStroke(String str) {
        int    state = 0;
        int    code  = 0;
        int    modif = 0;
        int    i     = 0;

        while (state != 100 && i < str.length()) {
            char curr = Character.toUpperCase(str.charAt(i));
            
            switch (state) {
            case 0 :
                code = curr;
                switch (curr) {
                case 'C': state = 1; break;
                case 'A': state = 5; break;
                case 'M': state = 8; break;
                case 'S': state = 12; break;
                default:
                    state = 100;
                }
                break;

            case 1 : state = (curr == 'T') ? 2 : 100; break;
            case 2 : state = (curr == 'R') ? 3 : 100; break;
            case 3 : state = (curr == 'L') ? 4 : 100; break;
            case 4 : state = (curr == '+') ? 0 : 100;
                if (state == 0) {
                    modif |= Event.CTRL_MASK;
                }
                break;
            case 5 : state = (curr == 'L') ? 6 : 100; break;
            case 6 : state = (curr == 'T') ? 7 : 100; break;
            case 7 : state = (curr == '+') ? 0 : 100;
                if (state == 0) {
                    modif |= Event.ALT_MASK;
                }
                break;
            case 8 : state = (curr == 'E') ? 9 : 100; break;
            case 9 : state = (curr == 'T') ? 10: 100; break;
            case 10: state = (curr == 'A') ? 11: 100; break;
            case 11: state = (curr == '+') ? 0 : 100;
                if (state == 0) {
                    modif |= Event.META_MASK;
                }
                break;
            case 12: state = (curr == 'H') ? 13: 100; break;
            case 13: state = (curr == 'I') ? 14: 100; break;
            case 14: state = (curr == 'F') ? 15: 100; break;
            case 15: state = (curr == 'T') ? 16: 100; break;
            case 16: state = (curr == '+') ? 0 : 100;
                if (state == 0) {
                    modif |= Event.SHIFT_MASK;
                }
                break;
            }
            i++;
        }
        if (code > 0 && modif > 0) {
        	
        	String rest = str.substring(i-1);
        	if (rest.equals("F1"))
        		code = KeyEvent.VK_F1;
        	else if (rest.equals("F2"))
        		code = KeyEvent.VK_F2;
        	else if (rest.equals("F3"))
        		code = KeyEvent.VK_F3;
        	else if (rest.equals("F4"))
        		code = KeyEvent.VK_F4;
        	else if (rest.equals("F5"))
        		code = KeyEvent.VK_F5;
        	else if (rest.equals("F6"))
        		code = KeyEvent.VK_F6;
        	else if (rest.equals("F7"))
        		code = KeyEvent.VK_F7;
        	else if (rest.equals("F8"))
        		code = KeyEvent.VK_F8;
        	else if (rest.equals("F9"))
        		code = KeyEvent.VK_F9;
        	else if (rest.equals("F10"))
        		code = KeyEvent.VK_F10;
        	else if (rest.equals("F11"))
        		code = KeyEvent.VK_F11;
        	else if (rest.equals("F12"))
        		code = KeyEvent.VK_F12;
        	else {
	            if (i < str.length()) {
	                char curr = Character.toUpperCase(str.charAt(i));
	                switch (code) {
	                case 'U':
	                    if (str.length() - i != 1 || curr != 'P') {
	                        break;
	                    }
	                    code = KeyEvent.VK_UP;
	                    break;
	                case 'L':
	                    if (str.length() - i != 3 ||
	                        curr != 'E' ||
	                        Character.toUpperCase(str.charAt(i + 1)) != 'F' ||
	                        Character.toUpperCase(str.charAt(i + 2)) != 'T') {
	                        break;
	                    }
	                    code = KeyEvent.VK_LEFT;
	                    break;
	                case 'D':
	                    if (str.length() - i != 3 ||
	                        curr != 'O' ||
	                        Character.toUpperCase(str.charAt(i + 1)) != 'W' ||
	                        Character.toUpperCase(str.charAt(i + 2)) != 'N') {
	                        break;
	                    }
	                    code = KeyEvent.VK_DOWN;
	                    break;
	                case 'R':
	                    if (str.length() - i != 4 ||
	                        curr != 'I' ||
	                        Character.toUpperCase(str.charAt(i + 1)) != 'G' ||
	                        Character.toUpperCase(str.charAt(i + 2)) != 'H' ||
	                        Character.toUpperCase(str.charAt(i + 3)) != 'T') {
	                        break;
	                    }
	                    code = KeyEvent.VK_RIGHT;
	                }
	            }
        	}
            return KeyStroke.getKeyStroke(code, modif);
        }
        return null;
    }
}
