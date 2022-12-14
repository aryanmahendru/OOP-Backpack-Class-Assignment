Backpack bluebackpack=new Backpack("Blue","small");// Backpack1
Backpack redbackpack=new Backpack("Red","medium");// Backpack2
Backpack greenbackpack=new Backpack("Green","large");// Backpack3


bluebackpack.OpenBag();//opening my blue backpack
bluebackpack.Putin("Lunch");
bluebackpack.Putin("Jacket");
bluebackpack.CloseBag();//closing my blue backpack
bluebackpack.OpenBag();
bluebackpack.Takeout("Jacket");
bluebackpack.CloseBag();



class Backpack{
    public string Colour{get;set;}
    public string Size{get;set;}
    public List<string> items{get;set;}
    public bool Open{get;set;}

    public Backpack(string colour,string size){
        this.Colour=colour;
        this.Size=size;
        this.items=new List<string>();
        this.Open=false;
    }

    public void OpenBag(){  //function for my backpack to open
        if(Open == false ){    //checking if the backpack is closed or not
            Open=true;
            Console.WriteLine(Colour+" backpack opened");

        }
        else{  //giving a message if it is already opened
            Console.WriteLine(Colour+" Backpack already opened");
        }
        
    }
    public void CloseBag(){//function for my backpack to close
        if(Open == true){//checking if the backpack is opened or not
            Open=false;
            Console.WriteLine(Colour+" backpack closed");
        }
        else{   //giving a message if it is already closed
            Console.WriteLine(Colour+" Backpack Arleady closed");
        }

    }

    public void Putin(string usrinput){  //taking a string to add item to the list for the backpack
        if(Open == true){  //checking if the bag is opened or not 
            items.Add(usrinput);
            Console.WriteLine(usrinput+" Added in "+Colour+" Backpack");
        }
        else{//if backpack is closed this message will be displayed
            Console.WriteLine("Backpack is closed please open it to add the item");
        }
    }

    int index=0;//for checking if the item is present or not in list

    public void Takeout(string userinput){//taking a string to remove item from the list of backpack
        if (Open == true){ 
            for(int i=0;i<items.Count;i++){//loop to check each item in list 
                if (items[i] == userinput){
                    items.Remove(items[i]);  //removing the item if present in list
                    index=1;
                    Console.WriteLine(userinput+" taken out");
                }

            }

            if(index == 0){
                Console.WriteLine(userinput+" not present in backpack");
            }
            index=0;//setting index again to zero for next time use
        }
        else{
            Console.WriteLine("Backpack is closed please open it to remove item");
        }

    }


}