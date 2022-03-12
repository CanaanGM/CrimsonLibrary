namespace CrimsonLibrary.Data.Models
{
    public class RequestParams
    {
        public int MaxPageSize { get; set; } = 50;
        private int _PageSize { get; set; } = 10;
        public int PageNumber { get; set; } = 1;

        public int PageSize
        {
            get
            {
                return _PageSize;
            }
            set
            {
                _PageSize = (value > MaxPageSize) ? MaxPageSize : value;
            }
        }
    }
}