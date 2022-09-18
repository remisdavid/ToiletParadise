namespace ToiletParadise.Models
{
    public class Codes
    {
        private class CodesItem
        {
            private int id;
            private int code;
            private DateTime date;

            public int Code { get => code; set => code = value; }
            public DateTime Date { get => date; set => date = value; }
            public int Id { get => id; set => id = value; }

            public CodesItem(int id)
            {
                Id = id;
            }

            public CodesItem(int code, DateTime date)
            {
                Code = code;
                Date = date;
            }


        }




    }
}
