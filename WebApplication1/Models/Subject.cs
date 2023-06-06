namespace WebApplication1.Models
{
	
    public class Subject
	{
		public int Id { get; set; }
		public string Category { get; set; }

		public static List<Subject> Subjects { get; set; } = new List<Subject>();

		public static List<Subject> GetSubjects()
		{
			if (Subjects.Count == 0)
			{
				Subjects.Add(new Subject { Category = "Ekonomi", Id = 1 });
				Subjects.Add(new Subject { Category = "Data & IT", Id = 2 });
				Subjects.Add(new Subject { Category = "Kultur & Media", Id = 3 });
				Subjects.Add(new Subject { Category = "Sport", Id = 4 });
			}
			return Subjects;
		}
	}
}
