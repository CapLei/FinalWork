string[] arrayOne = new string[3] {"hello","java","iT"};
string[] arrayTwo = new string[arrayOne.Length];

void CreateNewArray (string[] arrayOne, string[] arrayTwo){
    int count = 0;
    for (int i=0; i<arrayOne.Length; i++){
        if(arrayOne[i].Length <=3){
            arrayTwo[count] = arrayOne[i];
            count++;
        }
    }
}

void PrintNewArray (string[] array){
    for (int i = 0; i<array.Length; i++){
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

CreateNewArray(arrayOne,arrayTwo);
PrintNewArray(arrayTwo);