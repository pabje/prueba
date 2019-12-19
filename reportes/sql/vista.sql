--VALIDACION DE LA VISTA
if OBJECT_ID('vw_listadocomprobante')IS NOT NULL
		DROP VIEW vw_listadocomprobante

GO

CREATE VIEW vw_listadocomprobante
AS
select * from dbo.[dace.ComprobanteCFDI]
GO

select * from vw_listadocomprobante