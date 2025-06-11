namespace Pokekotas.Domain.Models
{ 
    public class BaseResponse<T> 
    {
        public bool IsSuccess { get { return Message.Count == 0; } }
        public List<string> Message { get; set; } = [];
        public List<T> ListResponse { get; set; } = [];
        public int? ErrorCode { get; set; } = null;
    }
}
