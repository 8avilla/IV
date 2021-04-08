USE prueba;
CREATE TABLE Mecanicos  
  (  
     tipo_documento     VARCHAR(2) NOT NULL,  
     documento			INTEGER NOT NULL,  
     primer_nombre		VARCHAR(10) NOT NULL,  
     segundo_nombre		VARCHAR(30),  
     primer_apellido	VARCHAR(30) NOT NULL,  
	 segundo_apellido	VARCHAR(30) NOT NULL,  
	 celular			VARCHAR(10) NOT NULL,  
	 direccion			VARCHAR(200) NOT NULL,  
	 email				VARCHAR(100) NOT NULL,  
	 estado				CHAR(1) NOT NULL, 
	 PRIMARY KEY (tipo_documento, documento)
  )  
  go

  create PROCEDURE [dbo].[MecanicosMaster](@tipo_documento     VARCHAR(2),  
     @documento			INTEGER,  
     @primer_nombre		VARCHAR(10) = '',  
     @segundo_nombre		VARCHAR(30) = '',  
     @primer_apellido	VARCHAR(30) = '',  
	 @segundo_apellido	VARCHAR(30) = '',  
	 @celular			VARCHAR(10) = '',  
	 @direccion			VARCHAR(200) = '',  
	 @email				VARCHAR(100) = '',  
	 @estado				CHAR(1) = '', 
                                          @StatementType NVARCHAR(20) = '')  
AS  
  BEGIN  
      IF @StatementType = 'Insert'  
        BEGIN  
            INSERT INTO Mecanicos  
                        ( tipo_documento,  
						 documento,  
						 primer_nombre,  
						 segundo_nombre,  
						 primer_apellido,  
						 segundo_apellido,  
						 celular,  
						 direccion,  
						 email,  
						 estado)  
            VALUES     ( @tipo_documento,  
						 @documento,  
						 @primer_nombre,  
						 @segundo_nombre,  
						 @primer_apellido,  
						 @segundo_apellido,  
						 @celular,  
						 @direccion,  
						 @email,  
						 @estado);

						 SELECT TOP (1) *  
            FROM   Mecanicos  WHERE  tipo_documento = tipo_documento AND documento  = @documento;
        END  
  
      IF @StatementType = 'Select'  
        BEGIN  
            SELECT *  
            FROM   Mecanicos  
        END  
  
      IF @StatementType = 'Update'  
        BEGIN  
            UPDATE Mecanicos  
            SET    tipo_documento  = @tipo_documento,  
					documento  = @documento,  
					primer_nombre  = @primer_nombre,  
					segundo_nombre  = @segundo_nombre,  
					primer_apellido  = @primer_apellido,  
					segundo_apellido  = @segundo_apellido,  
					celular  = @celular,  
					direccion  = @direccion,  
					email  = @email,  
					estado  = @estado  
            WHERE  tipo_documento = tipo_documento AND documento  = @documento;

			SELECT TOP (1) *  
            FROM   Mecanicos  WHERE  tipo_documento = tipo_documento AND documento  = @documento;
        END  
      ELSE IF @StatementType = 'Delete'  
        BEGIN  
            DELETE FROM Mecanicos  
            WHERE  tipo_documento = tipo_documento AND documento  = @documento 
        END  
  END 