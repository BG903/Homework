using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{

    public class EvenOrOddEnumerator : IEnumerator
    {
        private int[] _array;
        private int index;
        public EvenOrOddEnumerator(int[] array, bool evenIndexes)
        {
            _array = array;
            index = evenIndexes ? index = -2 : index = -1;
        }

        public object Current
        {
            get
            {
                return _array[index];
            }
        }

        public bool MoveNext()
        {
            index += 2;
            if (index >= _array.Length)
            {
                return false;
            }

            return true;
        }
        //??
        public void Reset()
        {
            index = -1;
        }

    }
    public class BackEnumerator:IEnumerator
    {
        private int[] _array;
        private int index;
        public BackEnumerator(int[] array)
        {
            _array=array;
            index = array.Length;
        }
        public object Current
        {
            get
            {
                return _array[index];
            }
        }
        public bool MoveNext()
        {
            index--;
            if (index <= -1)
            {
                return false;
            }

            return true;
        }
        public void Reset()
        {
            index = _array.Length;
        }
    }
    public class ForwardEnumerator : IEnumerator
    {
        private int[] _array;
        private int index = -1;
        public ForwardEnumerator(int[] array)
        {
            _array = array;
        }

        public object Current
        {
            get
            {
                return _array[index];
            }
        }

        public bool MoveNext()
        {
            index++;
            if (index >= _array.Length)
            {
                return false;
            }

            return true;
        }

        public void Reset()
        {
            index = -1;
        }

    }
    public class Mover /*:IEnumerable*/ // we can use with or withouth this interface 
    {
        private int[] array = new int[5];
        private bool EvenIndexes;
        public Mover()
        {

        }
        public Mover(bool evenIndexes)
        {
            EvenIndexes = evenIndexes;
        }

        public IEnumerator GetEnumerator()
        {
            return new EvenOrOddEnumerator(array, EvenIndexes);
        }
    }
    public class Mover2:IEnumerable
    {
        private int[] array = new int[5];

        public IEnumerator GetEnumerator()
        {
            return new BackEnumerator(array);
        }
    }
    public class Program
    {
        public static void Main()
        {
            Mover2 mover2 = new Mover2();
            foreach (int i in mover2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            Mover mover = new Mover(false);
            foreach (int i in mover)
            {
                Console.WriteLine(i);
            }
        }
    }
}

