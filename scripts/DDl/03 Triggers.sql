delimiter $$

use 5to_comidapp $$
DELIMITER $$
create trigger aftinsVentaResto after insert on VentaResto

for each ROW

BEGIN

	 if EXISTS (select *

	from ventaResto

	where idResto = NEW.idResto and IdPlato= New.IdPlato and anio= new.anio and mes= NEW.mes) then

	update ventaResto set monto = monto + new.Monto where idResto= NEW.idResto and IdPlato= New.IdPlato and anio= new.anio and mes= NEW.mes;

	else

	insert into ventaResto (idResto,IdPlato, Anio,Mes, Monto)

	values (new.idResto, New.IdPlato, New.Anio, New.Mes, New.Monto);

	end if;

END $$

delimiter $$

create trigger aftDelPLatoPedido after update on VentaResto

for each ROW

BEGIN

	if EXISTS (select *

	from ventaResto

	where idResto = old.idResto and IdPlato= old.IdPlato and anio= old.anio and mes= old.mes) then
	update ventaResto set monto= monto - old.monto where idResto = old.idResto and IdPlato= old.IdPlato and anio= old.anio and mes= old.mes;

	end if ;

END $$