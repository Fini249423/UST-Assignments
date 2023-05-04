create trigger persn on persons
after insert
as
select 'person added';