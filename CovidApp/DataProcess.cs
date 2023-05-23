using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace CovidApp
{
    // each dataProcess will represent one state
    public class DataProcess
    {

        private LinkedList<SingleData> alphaOrder = new LinkedList<SingleData>();
        // alpha based on ethnic name
        private LinkedList<SingleData> numOrder = new LinkedList<SingleData>(); 
        // based one death number and case number, case & death put

        private string state;
        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public LinkedList<SingleData> AlphaOrder
        {
            get { return alphaOrder; }
            set { alphaOrder = value; }
        }

        public LinkedList<SingleData> NumOrder
        {
            get { return numOrder; }
            set { numOrder = value; }
        }

        string[] ethnics = null;
        string oneLine = null;

        public DataProcess(string[] ethnics, string oneLine)
        {
            this.ethnics = ethnics; // eg. State, Case_Asian, Case_Black ....
            this.oneLine = oneLine; // eg. DC, 12, 345....

            this.Parse();
            this.Show();
        }


        public void Parse()
        {
            string[] data = Regex.Split(oneLine, " *, *");
            for (int i = 0; i < data.Length; i++)
            {
                string s = data[i];
                SingleData sd = new SingleData();
                if (Int32.TryParse(s, out int numValue))
                {
                    // if it is convertale to number
                    sd.Data = numValue;
                    sd.Ethnic = ethnics[i].Split('_')[1];
                    sd.IsCase = ethnics[i].Contains("Case") ? true : false;


                    alphaOrder.AddLast(sd);
                }
                else if (s.Equals("NA"))
                {
                    sd.Data = -1;
                    sd.Ethnic = ethnics[i];
                    sd.IsCase = ethnics[i].Contains("Case") ? true : false;
                }
                else
                {
                    State = s;
                }
            }
        }

        /*
         * add single data to a state(dataprocess) 
         * alphabetically by it's ethnic type
         */
        public void alphaAdd(SingleData sd)
        {
            if (sd == null)
            {

            }
        }

        /*
         * add single data to a state(dataprocess) 
         * numerically by it's data value
         */
        public void numAdd(SingleData sd)
        {

        }

        public void Show()
        {
            Console.WriteLine(state);
            for (LinkedListNode<SingleData> node = alphaOrder.First;
                node != null; node = node.Next)
            {
                Console.WriteLine(node.Value.Ethnic + "  " +
                    node.Value.Data + node.Value.IsCase);
            }
        }

    }



    public class SingleData
    {
        private string ethnic;
        private Boolean isCase = true;
        private int data;

        public int Data
        {
            get { return data; }
            set { data = value; }
        }

        public string Ethnic
        {
            get { return ethnic; }
            set { ethnic = value; }
        }

        public Boolean IsCase
        {
            get { return isCase; }
            set { isCase = value; }
        }

    }

}

