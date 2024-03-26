string[] arrayOne = new string[3] {"hello","java","it"};
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

CreateNewArray(arrayOne,arrayTwo);