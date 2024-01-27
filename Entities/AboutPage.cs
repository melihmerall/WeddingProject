namespace WeddingProject.Entities
{
	public class AboutPage: BaseEntity
	{
		public string? AboutTitle { get; set; }
		public string? AboutSecondTitle { get; set; }
		public string? AboutDesc { get; set; }
        public string? AboutDescHome { get; set; }
        public string? AboutDescHome2 { get; set; }
        public string? AboutDescHome3 { get; set; }
        public string? AboutDescHomeImagePath1 { get; set; }
        public string? AboutDescHomeImagePath2 { get; set; }
        public string? AboutDescHomeImagePath3 { get; set; }
        public string? AboutDescHomeImagePath4 { get; set; }

        public string? AboutOurMission { get; set; }
        public string? AboutOurMissionDesc { get; set; }

        public string? OurMissionImgPath { get; set; }

		public string? Service1Count { get; set; }
		public string? Service1Title { get; set; }

		public string? Service2Count { get; set; }
		public string? Service2Title { get; set; }

		public string? Service3Count { get; set; }
		public string? Service3Title { get; set; }

		public string? Service4Count { get; set; }
		public string? Service4Title { get; set; }

	}
}
