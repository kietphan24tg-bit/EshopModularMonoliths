using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DDD;

//use to audit 
public interface IEntity<T> : IEntity
{
    public T Id { get; set; }
}


public interface IEntity
{
   public DateTime? CreatedAt { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? LastModified { get; set; }
    public string? LastModifiedBy { get; set; }


}
