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

package pkg4gewinnt;

public class Field {
    public static final int ROWNUM = 6, COLUMNNUM = 7;
    
    private static Token[][] fieldArray = new Token[6][7];
    
    public static void add(int rowCoord, int columnCoord, Token k) {
        if(rowCoord >= 0 && columnCoord >= 0) {
            fieldArray[rowCoord][columnCoord] = k;
        }
    }
    
    public static int countUsedFields(int columnId) {
        int count = 0;
        for(int i = Field.ROWNUM - 1; i >= 0; i--) {
            if(Field.getFieldArray()[i][columnId] != null) {
                count ++;
            }
        }
        return count;
    }
    
    public static Token[][] getFieldArray() {
        return fieldArray;
    }
    
    public static void reset() {
        for(int i = 0; i < ROWNUM; i++) {
            for(int j = 0; j < COLUMNNUM; j++) {
                fieldArray[i][j] = null;
            }
        }
    }
}
