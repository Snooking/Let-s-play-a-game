namespace LetsPlayAGame.BussinessLogic.CQRS
{
    public class Result
    {
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public object Product { get; set; }

        public static Result Success(object result)
        {
            return new Result
            {
                IsSuccess = true,
                Product = result,
                ErrorMessage = string.Empty
            };
        }

        public static Result Failed(string errorMessage)
        {
            return new Result
            {
                IsSuccess = false,
                ErrorMessage = errorMessage
            };
        }
    }
}
