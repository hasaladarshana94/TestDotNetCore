namespace UdemytestApp.API.Helpers
{
    public class UserParams
    {
        //for pagination purposes
        private const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int pageSize = 10;
        public int PageSize
        {
            get { return pageSize;}
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value;}
        }

        //for filter purposes
        public int UserId { get; set; }
        public string Gender { get; set; }
        public int MinAge { get; set; } = 18;
        public int MaxAge { get; set; } = 99;

        //for sorting purposes
        public string OrderBy { get; set; }

        //for get Likers and Likees
        public bool Likees { get; set; } = false;
        public bool Likers { get; set; } = false;
        
    }
}