module Customer

type Customer =
    {
        Name : string
        Phone : Phone option
        Email : Email option
        Address : Address option
    }

and Phone = Phone of string

and Email = Email of string

and Address =
    {
        Street : string
        Suburb : string
        City : string
        ZipCode : ZipCode
        Planet : string
    }

and ZipCode = ZipCode of string
