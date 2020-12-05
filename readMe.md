SQL COMMANDS FOR POPULATING THE DATABASE
1. Download the data from https://storage.googleapis.com/kaggle-data-sets/1908/17155/bundle/archive.zip?X-Goog-Algorithm=GOOG4-RSA-SHA256&X-Goog-Credential=gcp-kaggle-com%40kaggle-161607.iam.gserviceaccount.com%2F20201205%2Fauto%2Fstorage%2Fgoog4_request&X-Goog-Date=20201205T090932Z&X-Goog-Expires=259199&X-Goog-SignedHeaders=host&X-Goog-Signature=7ced22b72c46e7f5980fcbdb5d869e0749f7ba7c4c7385624ee8477d0a65be90bdf17763f613507c7a20cb028b8b4072e6040988ba1a69688ac27e2c7e071f750d831cf7588de57a8f48e2a91e8be98fa556eac8c9c8b1497981a674fe68692866c3f6362897ba68a6ad4b6890b19a228ffdb737e92957f40b9fde41a04d7f71bb5283af7a47069e8765cfccda960fd99e8ca83b8724c8753ba886cb37faedf0d474e5b3a83a757d131f374e214c309558209ea62f27699d3be1abcff8ed6ecb92a9ef7fe8028d0b365194708b0c8bfd6ea6d9a97f835a36ecbe37a66b10c1c25b82ab6d3d5b4f727f8f9b8099d0a0fda94674b37bb007f39f8b7cc7402790ae
2. upload csv file in SSMS into another table (or you can create a BULKCOPY in .net because in this way is not really straightforward)
3. 
insert into Companies 
select * from dbo.all_stocks_5yr

4.create view StockCompany as 

select id as CompanyId,c.Name,Date,OpenPrice,HighPrice,LowPrice,ClosePrice,Volume from Companies c
join  all_stocks_5y s on s.name = c.name
5.
CREATE PROCEDURE SEEDPREDICTIONS @Name nvarchar(30)
AS

INSERT INTO Predictions ([CompanyId]
      ,[OpenPrice]
      ,[ClosePrice]
      ,[HighPrice]
      ,[LowPrice]
      ,[Volume]
      ,[Date])
SELECT top 20 [CompanyId],[OpenPrice]
      ,[ClosePrice]
      ,[HighPrice]
      ,[LowPrice]
      ,[Volume]
      ,[Date]   FROM stockCompany y WHERE y.Name = @Name;

6.
DECLARE @company_name VARCHAR(MAX)
DECLARE cursor_company CURSOR
FOR SELECT 
        distinct  name
    FROM 
	Companies
OPEN cursor_company;

FETCH NEXT FROM cursor_company INTO 
    @company_name
WHILE @@FETCH_STATUS = 0
    BEGIN
	EXEC SEEDPREDICTIONS @Name = @company_name
        FETCH NEXT FROM cursor_company INTO 
            @company_name
    END;

CLOSE cursor_company;

DEALLOCATE cursor_company;

(if you get some errors related to Identity column, make sure that you remove only for the sake of the insert the primary key from Prediction, and after running the procedure don't forget to put it back.
