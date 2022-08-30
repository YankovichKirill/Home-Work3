Console.Write("Enter the number: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube){
    int counter = 0;
    int lenght = cube.Length;
    while (counter < lenght){
        cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
        counter++;
    }
}

void PrintArry(int[] coll){
    int count = coll.Length;
    int index = 0;
    while(index < count){
        Console.Write(coll[index] + " ");
        index++;
    }
}

int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);