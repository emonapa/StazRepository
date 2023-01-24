
namespace UniModel
{
    class Subject
    {
        public string name { get; set; }
        public bool isLecture { get; set; }
        public bool isExercise { get; set; }
        public int creditPoints { get; set; }

        public Subject(string name, bool isLecture, bool isExercise, int creditPoints)
        {
            this.name = name;
            this.isLecture = isLecture;
            this.isExercise = isExercise;
            this.creditPoints = creditPoints;
        }
    }
}
