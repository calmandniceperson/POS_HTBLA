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

/**
 *
 * @author mko
 */
public class Player {
    private int id;
    private int score;
    
    public Player(int id) {
        this.id = id;
        this.score = 0;
    }
    
    /*
     * Allows to increase the player's score
     */
    public void addScore(int points) {
        this.score += points;
    }
    
    public int getScore() {
        return this.score;
    }
}
