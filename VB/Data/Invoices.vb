Imports System
Imports System.Collections.Generic

Namespace DataInspectorCustomizationExample
	Public Class Invoices
		Private Shared rnd As New Random()
		Public Property Country() As String
		Public Property City() As String
		Public Property ProductName() As String
		Public Property OrderDate() As Date
		Public Property Quantity() As Integer
		Public Property Discount() As Double
		Public Property ExtendedPrice() As Double
		Public Property Freight() As Double
		Public Property UnitPrice() As Double

		Public Shared Function CreateData() As List(Of Invoices)
			Dim data As New List(Of Invoices)()
			data.Add(New Invoices With {.Country = "Germany", .City = "Aachen", .ProductName = "Raclette Courdavault", .OrderDate = GenerateOrderDate(), .Quantity = 30, .Discount = 0, .ExtendedPrice = 1650, .Freight = 149.47, .UnitPrice = 55})
			data.Add(New Invoices With {.Country = "Germany", .City = "Berlin", .ProductName = "Raclette Courdavault", .OrderDate = GenerateOrderDate(), .Quantity = 15, .Discount = 0, .ExtendedPrice = 825, .Freight = 69.53, .UnitPrice = 55})
			data.Add(New Invoices With {.Country = "Germany", .City = "Brandenburg", .ProductName = "Raclette Courdavault", .OrderDate = GenerateOrderDate(), .Quantity = 61, .Discount = 0, .ExtendedPrice = 2959, .Freight = 42.33, .UnitPrice = 99})
			data.Add(New Invoices With {.Country = "Germany", .City = "Brandenburg", .ProductName = "Raclette Courdavault", .OrderDate = GenerateOrderDate(), .Quantity = 24, .Discount = 0, .ExtendedPrice = 1320, .Freight = 29.59, .UnitPrice = 55})
			data.Add(New Invoices With {.Country = "Germany", .City = "Cunewalde", .ProductName = "Camembert Pierrot", .OrderDate = GenerateOrderDate(), .Quantity = 55, .Discount = 0.1, .ExtendedPrice = 1346.4, .Freight = 183.17, .UnitPrice = 27.2})
			data.Add(New Invoices With {.Country = "Germany", .City = "Cunewalde", .ProductName = "Camembert Pierrot", .OrderDate = GenerateOrderDate(), .Quantity = 139, .Discount = 0.2, .ExtendedPrice = 4204.1, .Freight = 568.62, .UnitPrice = 68})
			data.Add(New Invoices With {.Country = "Germany", .City = "Cunewalde", .ProductName = "Camembert Pierrot", .OrderDate = GenerateOrderDate(), .Quantity = 49, .Discount = 0.25, .ExtendedPrice = 1249.5, .Freight = 31.89, .UnitPrice = 34})
			data.Add(New Invoices With {.Country = "Germany", .City = "Cunewalde", .ProductName = "Raclette Courdavault", .OrderDate = GenerateOrderDate(), .Quantity = 70, .Discount = 0, .ExtendedPrice = 3850, .Freight = 401.88, .UnitPrice = 110})
			data.Add(New Invoices With {.Country = "Germany", .City = "Frankfurt a.M.", .ProductName = "Camembert Pierrot", .OrderDate = GenerateOrderDate(), .Quantity = 20, .Discount = 0.25, .ExtendedPrice = 408, .Freight = 76.56, .UnitPrice = 27.2})
			data.Add(New Invoices With {.Country = "Germany", .City = "Frankfurt a.M.", .ProductName = "Camembert Pierrot", .OrderDate = GenerateOrderDate(), .Quantity = 35, .Discount = 0.25, .ExtendedPrice = 892.5, .Freight = 58.88, .UnitPrice = 34})
			data.Add(New Invoices With {.Country = "Germany", .City = "Frankfurt a.M.", .ProductName = "Raclette Courdavault", .OrderDate = GenerateOrderDate(), .Quantity = 25, .Discount = 0, .ExtendedPrice = 1375, .Freight = 91.28, .UnitPrice = 55})
			data.Add(New Invoices With {.Country = "Germany", .City = "Cologne", .ProductName = "Camembert Pierrot", .OrderDate = GenerateOrderDate(), .Quantity = 30, .Discount = 0, .ExtendedPrice = 1020, .Freight = 145.63, .UnitPrice = 34})
			data.Add(New Invoices With {.Country = "Germany", .City = "Leipzig", .ProductName = "Raclette Courdavault", .OrderDate = GenerateOrderDate(), .Quantity = 12, .Discount = 0, .ExtendedPrice = 660, .Freight = 127.34, .UnitPrice = 55})
			data.Add(New Invoices With {.Country = "Germany", .City = "Mannheim", .ProductName = "Camembert Pierrot", .OrderDate = GenerateOrderDate(), .Quantity = 21, .Discount = 0, .ExtendedPrice = 714, .Freight = 31.14, .UnitPrice = 34})
			data.Add(New Invoices With {.Country = "Germany", .City = "Munich", .ProductName = "Raclette Courdavault", .OrderDate = GenerateOrderDate(), .Quantity = 70, .Discount = 0.15, .ExtendedPrice = 2618, .Freight = 208.58, .UnitPrice = 44})
			data.Add(New Invoices With {.Country = "Germany", .City = "Munich", .ProductName = "Raclette Courdavault", .OrderDate = GenerateOrderDate(), .Quantity = 30, .Discount = 0, .ExtendedPrice = 1320, .Freight = 4.93, .UnitPrice = 44})
			data.Add(New Invoices With {.Country = "Germany", .City = "Munich", .ProductName = "Camembert Pierrot", .OrderDate = GenerateOrderDate(), .Quantity = 20, .Discount = 0.1, .ExtendedPrice = 612, .Freight = 93.25, .UnitPrice = 34})
			data.Add(New Invoices With {.Country = "Germany", .City = "Munich", .ProductName = "Camembert Pierrot", .OrderDate = GenerateOrderDate(), .Quantity = 36, .Discount = 0.05, .ExtendedPrice = 1162.8, .Freight = 242.95, .UnitPrice = 34})
			data.Add(New Invoices With {.Country = "USA", .City = "Albuquerque", .ProductName = "Raclette Courdavault", .OrderDate = GenerateOrderDate(), .Quantity = 60, .Discount = 0, .ExtendedPrice = 2640, .Freight = 708.95, .UnitPrice = 44})
			data.Add(New Invoices With {.Country = "USA", .City = "Albuquerque", .ProductName = "Camembert Pierrot", .OrderDate = GenerateOrderDate(), .Quantity = 21, .Discount = 0, .ExtendedPrice = 571.2, .Freight = 147.26, .UnitPrice = 27.2})
			data.Add(New Invoices With {.Country = "USA", .City = "Albuquerque", .ProductName = "Camembert Pierrot", .OrderDate = GenerateOrderDate(), .Quantity = 2, .Discount = 0.06, .ExtendedPrice = 63.92, .Freight = 8.53, .UnitPrice = 34})
			data.Add(New Invoices With {.Country = "USA", .City = "Anchorage", .ProductName = "Raclette Courdavault", .OrderDate = GenerateOrderDate(), .Quantity = 8, .Discount = 0, .ExtendedPrice = 440, .Freight = 135.63, .UnitPrice = 55})
			data.Add(New Invoices With {.Country = "USA", .City = "Boise", .ProductName = "Raclette Courdavault", .OrderDate = GenerateOrderDate(), .Quantity = 40, .Discount = 0.15, .ExtendedPrice = 1496, .Freight = 214.27, .UnitPrice = 44})
			data.Add(New Invoices With {.Country = "USA", .City = "Boise", .ProductName = "Raclette Courdavault", .OrderDate = GenerateOrderDate(), .Quantity = 7, .Discount = 0, .ExtendedPrice = 385, .Freight = 8.19, .UnitPrice = 55})
			data.Add(New Invoices With {.Country = "USA", .City = "Boise", .ProductName = "Raclette Courdavault", .OrderDate = GenerateOrderDate(), .Quantity = 100, .Discount = 0.25, .ExtendedPrice = 4125, .Freight = 830.75, .UnitPrice = 55})
			data.Add(New Invoices With {.Country = "USA", .City = "Boise", .ProductName = "Camembert Pierrot", .OrderDate = GenerateOrderDate(), .Quantity = 70, .Discount = 0, .ExtendedPrice = 2380, .Freight = 896.77, .UnitPrice = 68})
			data.Add(New Invoices With {.Country = "USA", .City = "Boise", .ProductName = "Camembert Pierrot", .OrderDate = GenerateOrderDate(), .Quantity = 45, .Discount = 0.2, .ExtendedPrice = 1224, .Freight = 487.57, .UnitPrice = 34})
			data.Add(New Invoices With {.Country = "USA", .City = "Eugene", .ProductName = "Raclette Courdavault", .OrderDate = GenerateOrderDate(), .Quantity = 30, .Discount = 0.15, .ExtendedPrice = 1402.5, .Freight = 18.53, .UnitPrice = 55})
			data.Add(New Invoices With {.Country = "USA", .City = "Eugene", .ProductName = "Camembert Pierrot", .OrderDate = GenerateOrderDate(), .Quantity = 15, .Discount = 0, .ExtendedPrice = 510, .Freight = 14.01, .UnitPrice = 34})
			data.Add(New Invoices With {.Country = "USA", .City = "Lander", .ProductName = "Camembert Pierrot", .OrderDate = GenerateOrderDate(), .Quantity = 20, .Discount = 0.2, .ExtendedPrice = 435.2, .Freight = 30.96, .UnitPrice = 27.2})
			data.Add(New Invoices With {.Country = "USA", .City = "Portland", .ProductName = "Raclette Courdavault", .OrderDate = GenerateOrderDate(), .Quantity = 1, .Discount = 0, .ExtendedPrice = 55, .Freight = 26.31, .UnitPrice = 55})
			data.Add(New Invoices With {.Country = "USA", .City = "Seattle", .ProductName = "Raclette Courdavault", .OrderDate = GenerateOrderDate(), .Quantity = 30, .Discount = 0, .ExtendedPrice = 1650, .Freight = 606.19, .UnitPrice = 55})
			Return data
		End Function

		Private Shared Function GenerateOrderDate() As Date
			Dim startYear As Integer = Date.Today.Year - 3
			Dim endYear As Integer = Date.Today.Year
			Return New Date(rnd.Next(startYear, endYear), rnd.Next(1, 13), rnd.Next(1, 29))
		End Function
	End Class
End Namespace