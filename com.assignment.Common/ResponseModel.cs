using System.Collections;
using System.Net;

namespace com.assignment.Common;

public class ResponseModel
{
    public string Data { get; set; }
    public IList<ResponseMessage> Messages { get; set; } = new List<ResponseMessage>();
    public int Status { get; set; } = (int)HttpStatusCode.OK;
}