namespace TextFileChallenge.Model
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsAlive { get; set; }

        public string DisplayText
        {
            get
            {
                string aliveStatus = "is dead";

                if (IsAlive == true)
                {
                    aliveStatus = "is alive";
                }

                return $"{ FirstName} { LastName } is { Age } and { aliveStatus }";
            }
        }

        public override bool Equals(object obj)
        {
            User other = obj as User;
            return Equals(other);
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode()
                ^ LastName.GetHashCode()
                ^ Age.GetHashCode()
                ^ IsAlive.GetHashCode();
        }

        public bool Equals(User other)
        {
            if (other == null)
                return false;

            return this.FirstName == other.FirstName
                && this.LastName == other.LastName
                && this.Age == other.Age
                && this.IsAlive == other.IsAlive;
        }
    }
}
