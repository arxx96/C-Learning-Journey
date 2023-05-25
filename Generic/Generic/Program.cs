namespace Generic
{
    internal class Program
    {



        //Generic class

        class ARR<T>
        {
            private T[] _items;

            //method to add in array
            public void add(T items) {
                if (_items is null)
                {
                    _items = new T[] {items};
                   
                }
                else { 
                    int length = _items.Length;
                    T[] temp = new T[length+1];
                    for (int i = 0; i < length; i++)
                  
                    {

                        temp[i] = _items[i];

                    }
                    temp[length] = items;
                     _items = temp;
                  
                }

            }
            //method to remove in array
            public void Removeat(int index) {
                T[] temp = new T[_items.Length-1];
                int pos = 0;
                for (int i = 0; i <_items.Length ; i++)
                {
                    if (i == index) {
                        continue; 
                    }

                temp[pos++] = _items[i];
                }
               
                _items = temp;
            }
            


           public void Display()
            {
                foreach (T item in _items)
                {
                    Console.Write(item + " ");
                }
            }





        }





        static void Main(string[] args)
        {
           

          
            ARR<int> numbers = new ARR<int>();  
            numbers.add(1);
            numbers.add(2);
            numbers.add(3);
            numbers.Removeat(2);



            numbers.Display();

           
            //List<int> pepole= new List<int>();

        }
    }
}