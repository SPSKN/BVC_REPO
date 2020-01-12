SELECT ItemID, ItemPrice, DiscountAmount, Quantity,
ItemPrice * Quantity AS PriceTotal,
DiscountAmount * Quantity AS DiscountTotal,
(ItemPrice - DiscountAmount) * Quantity AS ItemTotal
FROM OrderItems
