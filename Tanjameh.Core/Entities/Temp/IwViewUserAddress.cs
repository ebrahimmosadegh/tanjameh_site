using System;
using System.Collections.Generic;

namespace Tanjameh.Core.Entities.Temp;

public partial class IwViewUserAddress
{
    public int Id { get; set; }

    public bool Enabled { get; set; }

    public int UserId { get; set; }

    public bool IsDefault { get; set; }

    public DateTime? LastModify { get; set; }

    public int IwUserAddressDetailsId { get; set; }

    public string AddressNicname { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string AddressDescription { get; set; } = null!;

    public string? AddressOtherTel { get; set; }

    public int IwCountryId { get; set; }

    public string City { get; set; } = null!;

    public string? AddressUserName { get; set; }

    public string? AddressUserFamily { get; set; }

    public string? AddressUserGender { get; set; }

    public string AddressPostCode { get; set; } = null!;

    public string CountryName { get; set; } = null!;
}
