DELIMITER $$
use 5to_comidapp $$
DELIMITER $$

CALL RegistrarCliente(1, 'Tic@gmail.com', 'Tic','Ramatra', 'tocotoc');
CALL RegistrarCliente(2,'tictoc@gmail.com','Tiva', 'Soldadito','1315');
CALL RegistrarCliente(3,'combo@gmail.com', 'Vick', 'Carta', 'diovo');
CALL AltaRestaurante(11, 'Pollos X2', 'shot1500', 'tolft', 'pollos@gmail.com');
CALL AltaRestaurante(22, 'Carne Simba', 'Castillo2324', '23456', 'Simba@gmail.com');
CALL AltaPlato(21,11, 'Brochetas de Pollo', 'pollo en Brochetas', 12.34, 1);
CALL AltaPlato(12,22, 'Tamales', 'Son Tamales', 23.45, 1);
CALL AltaPedido(31, '2023-11-12', 3, 'brochetas de pollo', 11, 2);
CALL AltaPedido(13, '2023-10-23', 4, 'Tamales', 22, 3);
CALL AltaPlatoPedido(21, 31, 32, 343.32);
CALL AltaPlatoPedido(12,13,32, 345.34);