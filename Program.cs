//Bo'luvchisiz sonlar:
Console.WriteLine("Bo'luvchilar soni! \nInput: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Output = ");
bool first=true;
for (int i=2; i<=10; i++){
    if(n%i==0){
        if(!first){
            Console.Write(",");
        }
        Console.Write(i);
        first =false;
    }

}
