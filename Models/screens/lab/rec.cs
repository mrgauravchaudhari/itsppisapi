using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace itsppisapi.Models 
{
    public class rec : IEquatable<rec>
    {
    public string L_REPORT_NAME { get; set; }
    public string L_REP_UNIT { get; set; }
    public decimal L_REP_PRINT_SEQ { get; set; }
    public string L_REPORT_DESC { get; set; }
    public string L_ACTIVE_FLG { get; set; }
    public string DEPT_NAME { get; set; }
    public List<string> L_TIME { get; set; }
    public string L_DEPT_CODE { get; set; }

    public bool Equals(rec other)
    {

        //Check whether the compared object is null.
        if (Object.ReferenceEquals(other, null)) return false;

        //Check whether the compared object references the same data.
        if (Object.ReferenceEquals(this, other)) return true;

        //Check whether the products' properties are equal.
        return L_REP_PRINT_SEQ.Equals(other.L_REP_PRINT_SEQ) && L_REPORT_NAME.Equals(other.L_REPORT_NAME);
    }

    // If Equals() returns true for a pair of objects
    // then GetHashCode() must return the same value for these objects.

    public override int GetHashCode()
    {

        //Get hash code for the Name field if it is not null.
        int hashProductName = L_REPORT_NAME == null ? 0 : L_REPORT_NAME.GetHashCode();

        //Get hash code for the Code field.
        int hashProductCode = L_REP_PRINT_SEQ.GetHashCode();

        //Calculate the hash code for the product.
        return hashProductName ^ hashProductCode;
    }


    }
}
