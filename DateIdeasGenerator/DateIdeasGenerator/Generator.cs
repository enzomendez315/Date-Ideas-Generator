//using Newtonsoft.Json;

namespace DateIdeasGenerator
{
    public class Generator
    {
        private HashSet<string> dateIdeas;
        private Dictionary<DateTime, string> tracker;

        //[JsonObject(MemberSerialization.OptIn)]
        public Generator()
        {
            dateIdeas = new HashSet<string>();
            tracker = new Dictionary<DateTime, string>();
        }

        // Create a constructor for deserializing files.

        /// <summary>
        /// Saves the state of the generator by serializing JSON properties and saving them to a file.
        /// </summary>
        /// <param name="filename"></param>
        public void Save(string filename)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds date idea to list of dates.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public bool AddDate(string date)
        {
            if (dateIdeas.Contains(date))
                return false;
            else
                dateIdeas.Add(date);

            return true;
        }

        /// <summary>
        /// Removes date idea from list of dates.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public bool RemoveDate(string date)
        {
            if (!dateIdeas.Contains(date))
                return false;
            else
                dateIdeas.Remove(date);

            return true;
        }

        /// <summary>
        /// Chooses a date idea from the hashset at random.
        /// </summary>
        /// <returns></returns>
        public string GenerateDate()
        {
            if (dateIdeas.Count == 0)
                throw new ArgumentException();

            Random random = new Random();
            string[] temp = dateIdeas.ToArray();
            string date = temp[random.Next(temp.Length)];
            AddToTracker(date);

            return date;
        }

        private bool AddToTracker(string date)
        {
            // Add the date to the tracker to avoid choosing it again in the near future.
            throw new NotImplementedException();
        }

        private bool RemoveFromTracker(string date)
        {
            // Remove the date from the tracker.
            throw new NotImplementedException();
        }
    }
}