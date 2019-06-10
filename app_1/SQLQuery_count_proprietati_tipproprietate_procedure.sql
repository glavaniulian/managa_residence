create procedure usp_chart2
as
begin

Select count(proprietati.id) as 'Total',proprietati.tipproprietate as 'Proprietate'
from proprietati
group by proprietati.tipproprietate

end