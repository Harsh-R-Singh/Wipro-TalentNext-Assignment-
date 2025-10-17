SELECT 
    SpecialOfferID,
    Description,
    ISNULL(MaxQty, 10) * DiscountPCT AS AdjustedDiscount
FROM 
    Sales.SpecialOffer;
