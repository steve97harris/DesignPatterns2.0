using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns._03_Behavioral._04_Iterator.RadioStation
{
    public class StationList : IEnumerable<RadioStation>
    {
        // Concrete Aggregate
        List<RadioStation> mStations = new List<RadioStation>();

        public RadioStation this[int index]
        {
            get
            {
                return mStations[index];
            }
            set
            {
                mStations.Insert(index, value); // Inserts an element into the List<RadioStation> at the specified index.
            }
        }

        // Concrete Iterator
        public void Add(RadioStation radioStation)
        {
            mStations.Add(radioStation);
        }

        public void Remove(RadioStation radioStation)
        {
            mStations.Remove(radioStation);
        }

        // Iterator
        public IEnumerator<RadioStation> GetEnumerator()
        {
            return mStations.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}