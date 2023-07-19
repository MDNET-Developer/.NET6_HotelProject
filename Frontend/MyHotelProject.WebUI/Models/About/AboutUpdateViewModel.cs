namespace MyHotelProject.WebUI.Models.About
{
    public class AboutUpdateViewModel
    {
        public int AboutID { get; set; }
        public string? Title { get; set; }
        public string? Title2 { get; set; }
        public string? Content { get; set; }
        public int RoomCount { get; set; }
        public int CustomerCount { get; set; }
    }
}
