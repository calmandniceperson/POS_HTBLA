/*
 * Copyright (C) 2015 mko
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
 */
package memory;

import java.util.ArrayList;
import java.util.Collections;
import java.util.HashMap;
import javafx.scene.paint.Color;
import javafx.scene.shape.Rectangle;

/**
 *
 * @author mko
 */
public class Memory {
    /*
     * ArrayList for storing the fields' colors
     * Every color is added twice (in 2 entries)
     * then the entries are shuffled to randomise
     * the arrangement of fields
     */
    private final ArrayList<Color> colorList;
    
    /*
     * ArrayList for storing the Rectangles themselves
     * as MemoryRectangles (extending Rectangle).
     * This list is used to compare against the color list. 
     * Index 2 in the color list is then basically attached to the
     * element with index 2 in the rectangle list.
     */
    private final ArrayList<MemoryRectangle> rectList;
    
    /*
     * HashMap for storing the players
     * Both players (could of course also be more) are added to the array
     * This HashMap grants access to the players' scores and IDs to manipulate them.
     * Scores are manipulated from the DocumentController through this HashMap
     */
    private final HashMap playerMap;

    public Memory(int playerCount) {
        /*
         * use new Lists and Maps every time
         * (needs replacement)
         */
        this.playerMap = new HashMap();
        this.colorList = new ArrayList<>();
        this.rectList = new ArrayList<>();
        
        /*
         * Loop through the player list and
         * add an amount of players.
         * The amount of players can be set via the playerCount
         * parameter.
         */
        for (int i = 1; i <= playerCount; i++) {
            this.playerMap.put(i, new Player(i));
        }
        
        /*
         * Add multiple colors for the rectangles
         * Every color is added twice and after that
         * the List is shuffled to ensure a random
         * arrangement of colored rectangles.
         */
        colorList.add(Color.web("#E91E63"));
        colorList.add(Color.web("#E91E63"));
        colorList.add(Color.web("#00E676"));
        colorList.add(Color.web("#00E676"));
        colorList.add(Color.web("#673AB7"));
        colorList.add(Color.web("#673AB7"));
        colorList.add(Color.WHITE);
        colorList.add(Color.WHITE);
        colorList.add(Color.web("#64FFDA"));
        colorList.add(Color.web("#64FFDA"));
        colorList.add(Color.web("#FF5722"));
        colorList.add(Color.web("#FF5722"));
        Collections.shuffle(colorList);
    }

    /*
     * Allows to add MemoryRectangle entries
     * to the list of rectangles
     */
    public void addToRectList(MemoryRectangle rec) {
        rectList.add(rec);
    }

    /*
     * Returns the corresponding color to the
     * rectangle with the given ID. 
     * Loops through the list to find the rectangle
     * and then returns the color with the same index.
     */
    public Color getColorForRect(Rectangle rec) {
        for (int i = 0; i <= rectList.size() - 1; i++) {
            if (rec.equals(rectList.get(i))) {
                return colorList.get(i);
            }
        }
        return null;
    }
    
    public Player getPlayerById(int id) {
        return (Player) this.playerMap.get(id);
    }

    public HashMap getPlayerMap() {
        return this.playerMap;
    }

    public ArrayList getRectList() {
        return this.rectList;
    }
}
