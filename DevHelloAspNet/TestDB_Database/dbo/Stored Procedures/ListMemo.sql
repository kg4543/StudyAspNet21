Create Proc dbo.ListMemo
As
	Select Num, Name, Email, Title, PostDate, PostIP
	From Memos Order By Num Desc
