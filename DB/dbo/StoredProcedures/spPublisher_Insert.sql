CREATE PROCEDURE [dbo].[spPublisher_Insert]
	@PublisherName nvarchar(100),
	@PublisherEmail nvarchar(100),
	@PublisherPhone BIGINT
	
AS
begin
	insert into dbo.[Publisher] (PublisherFullName, PublisherEmail, PublisherPhone)
	values (@PublisherFulltName, @PublisherEmail, @PublisherPhone);
end
