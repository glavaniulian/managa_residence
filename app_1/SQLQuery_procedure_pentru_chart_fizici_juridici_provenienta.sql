Create procedure usp_chart2
as
begin
Select count(clienti_fizici.id_client)+(select count(id) from clienti_juridici where clienti_fizici.provenientaclient = clienti_juridici.provenientaclient) as 'Total',clienti_fizici.provenientaclient 'Provenienta'
from clienti_fizici
group by clienti_fizici.provenientaclient



end