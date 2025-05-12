using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwUser
{
    public int Id { get; set; }

    public bool Enabled { get; set; }

    public string Password { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Image { get; set; } = null!;

    public string? CellNumber { get; set; }

    public string Description { get; set; } = null!;

    public int CountEnter { get; set; }

    public string? NationalCode { get; set; }

    public int ChangePass { get; set; }

    public string? PreRefrence { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? LastModify { get; set; }

    public string? ModifyId { get; set; }

    public string? ModifyIp { get; set; }

    public int IwUserGroupId { get; set; }

    public virtual ICollection<IwPaymentState> IwPaymentStates { get; set; } = new List<IwPaymentState>();

    public virtual IwUserGroup IwUserGroup { get; set; } = null!;

    public virtual ICollection<IwUserObserver> IwUserObservers { get; set; } = new List<IwUserObserver>();

    public virtual ICollection<IwUserPacking> IwUserPackings { get; set; } = new List<IwUserPacking>();

    public virtual ICollection<IwUserPaymentMethod> IwUserPaymentMethods { get; set; } = new List<IwUserPaymentMethod>();

    public virtual ICollection<IwUserReview> IwUserReviews { get; set; } = new List<IwUserReview>();

    public virtual ICollection<IwUserShopOrder> IwUserShopOrders { get; set; } = new List<IwUserShopOrder>();

    public virtual ICollection<IwUserShoppingCart> IwUserShoppingCarts { get; set; } = new List<IwUserShoppingCart>();

    public virtual ICollection<IwUserTempCart> IwUserTempCarts { get; set; } = new List<IwUserTempCart>();
}
