using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShmelevAV.Sprint3.Task3.V3.Lib
{
    public class DataService : ISprint3Task3V3
    {
        public int GetMinCharCount(string value, char item)
        {
            int count = 0;
            foreach(char chr in value)
            {
                if(chr == item)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
