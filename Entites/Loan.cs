using System;
using System.Collections.Generic;

namespace MalinaoLoans.Entites;

public partial class Loan
{
    public int Id { get; set; }

    public int? Borrower { get; set; }

    public int? Amount { get; set; }

    public int? Term { get; set; }

    public double? Payment { get; set; }

    public double? PaymentAmount { get; set; }

    public double? InterestAmount { get; set; }

    public double? TotalAmount { get; set; }

    public double? Interest { get; set; }

    public double? Deduction { get; set; }

    public double? RecievableAmount { get; set; }

    public string? Status { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? DateCreated { get; set; }
}
