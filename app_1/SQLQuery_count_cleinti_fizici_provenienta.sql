


Select count(clienti_fizici.id_client)+(select count(id) from clienti_juridici where clienti_fizici.provenientaclient = clienti_juridici.provenientaclient) as 'Total',clienti_fizici.provenientaclient As 'Provenienta'
from clienti_fizici
group by clienti_fizici.provenientaclient