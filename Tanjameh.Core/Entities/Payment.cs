
  using System.ComponentModel.DataAnnotations;

namespace Tanjameh.Core.Entities;

public class Payment
  {
      public int Id { get; set; }
      public int CustomerOrderId { get; set; }
      [Required]
      public LegacyCustomerOrder CustomerOrder { get; set; }
      public decimal Amount { get; set; }
      public DateTime PaymentDate { get; set; }
      public PaymentMethod PaymentMethod { get; set; }

      [StringLength(50)]
      public string TransactionId { get; set; }
      public PaymentStatus Status { get; set; }
      public bool IsDeleted { get; set; }
      public DateTime? CreatedTime { get; set; }
      public DateTime? LastModify { get; set; }
  }

  public enum PaymentMethod
  {
      CreditCard,
      DebitCard,
      BankTransfer,
      PayPal,
      Cash
  }

  public enum PaymentStatus
  {
      Pending,
      Completed,
      Failed,
      Refunded
  }

  public class PaymentLog
  {
      public int Id { get; set; }
      public int PaymentId { get; set; }

      [Required]
      public Payment Payment { get; set; }

      [StringLength(50)]
      public string Action { get; set; }

      [StringLength(3000)]
      public string Details { get; set; }
      public DateTime Timestamp { get; set; }
      [StringLength(45)]
      public string IpAddress { get; set; }
      [StringLength(200)]
      public string UserAgent { get; set; }
      public bool IsDeleted { get; set; }
      public DateTime CreatedTime { get; set; }
  }

  public enum PaymentAction
  {
      Initiated,
      Authorized,
      Captured,
      Failed,
      Refunded,
      Voided
  }
