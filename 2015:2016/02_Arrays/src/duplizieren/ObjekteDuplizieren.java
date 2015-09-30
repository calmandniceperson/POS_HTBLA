package duplizieren;

public class ObjekteDuplizieren {
	public static void main(String[] args) {
		// deep copy
		Objekt[] objektArray = new Objekt[40];
		for (int i = 0; i < objektArray.length / 2; i++) {
			objektArray[i] = new Objekt(i);
		}
		objektArray = deepCopy(objektArray);
		for (int i = 0; i < objektArray.length; i++) {
			System.out.println(objektArray[i].getId());
		}
		
		System.out.println();

		// shallow copy
		Objekt[] objektArray_sc = new Objekt[40];
		for (int i = 0; i < objektArray_sc.length / 2; i++) {
			objektArray_sc[i] = new Objekt(i);
		}
		objektArray_sc = shallowCopy(objektArray_sc);
		for (int i = 0; i < objektArray_sc.length; i++) {
			System.out.println(objektArray_sc[i].getId());
		}

		// aufzeigen von deep copy
		objektArray[2 + (objektArray.length / 2)].setId(5);
		System.out.println("Durch das Verwenden von deep copy bleibt das Originalobjekt");
		System.out.println("unangtastet:");
		System.out.println("   - Original ID: " + objektArray[2].getId());
		System.out.println("   - Kopie    ID: " + objektArray[2 + (objektArray.length / 2)].getId());
		
		// aufzeigen von shallow copy
		objektArray_sc[2 + (objektArray_sc.length / 2)].setId(6);
		System.out.println("Durch das Verwenden von shallow copy ist das Originalobjekt");
		System.out.println("auch von Aenderungen betroffen:");
		System.out.println("   - Original ID: " + objektArray_sc[2].getId());
		System.out.println("   - Kopie    ID: " + objektArray_sc[2 + (objektArray_sc.length / 2)].getId());
	}

	public static Objekt[] deepCopy(Objekt[] objArr) {
		for (int i = 0; i < objArr.length / 2; i++) {
			objArr[i + (objArr.length / 2)] = new Objekt(objArr[i].getId());
		}
		return objArr;
	}

	public static Objekt[] shallowCopy(Objekt[] objArr) {
		for (int i = 0; i < objArr.length / 2; i++) {
			objArr[i + (objArr.length / 2)] = objArr[i];
		}
		return objArr;
	}
}
