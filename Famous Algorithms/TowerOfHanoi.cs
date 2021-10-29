#nullable disable

namespace Famous_Algorithms
{
    
    public class TowerOfHanoi
    {
        public int DiscsCount { get; private set; }
        public int MovesCount { get; private set; }
        public Stack<int> From {get; private set;}
        public Stack<int> To {get; private set;}
        public Stack<int> Aux {get; private set;}

        public event EventHandler<EventArgs> MovesCompleted;

        public TowerOfHanoi(int dics)
        {
            DiscsCount = dics;
            From = new Stack<int>();
            To = new Stack<int>();
            Aux = new Stack<int>();
            for(int i = 1; i <= dics; i++)
            {
                int size = dics - i - 1;
                From.Push(size);
            }
        }

        public void Start()
        {
            Move(DiscsCount, From, To, Aux);
        }

        public void Move(int dics, Stack<int> from, Stack<int> to, Stack<int> aux)
        {
            if(dics > 0)
            {
                Move(dics - 1, from, aux, to);
                to.Push(from.Pop());
                MovesCount++;
                MovesCompleted?.Invoke(this, EventArgs.Empty);
                Move(dics - 1, aux, to, from);
            }
        }
    }
}