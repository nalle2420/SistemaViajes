USE [BSistemaViajes]
GO
/****** Object:  Schema [Empleados]    Script Date: 25/9/2023 13:51:28 ******/
CREATE SCHEMA [Empleados]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 25/9/2023 13:51:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[Emp_ID] [int] IDENTITY(1,1) NOT NULL,
	[Emp_identidad] [varchar](15) NOT NULL,
	[Emp_Nombre] [varchar](50) NOT NULL,
	[Emp_Apellido] [varchar](50) NOT NULL,
	[Emp_Direccion] [varchar](100) NOT NULL,
	[Emp_Telefono] [varchar](15) NOT NULL,
	[Puesto_ID] [int] NOT NULL,
	[Emp_transporte] [bit] NOT NULL,
 CONSTRAINT [PK__Empleado__2623598BFDF47E44] PRIMARY KEY CLUSTERED 
(
	[Emp_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 25/9/2023 13:51:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso](
	[Permiso_ID] [int] IDENTITY(1,1) NOT NULL,
	[Puesto_ID] [int] NOT NULL,
	[NombreMenu] [varchar](100) NOT NULL,
 CONSTRAINT [PK__Permiso__985F9A5DAA10AB90] PRIMARY KEY CLUSTERED 
(
	[Permiso_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Puesto]    Script Date: 25/9/2023 13:51:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Puesto](
	[Puesto_ID] [int] IDENTITY(1,1) NOT NULL,
	[Puesto_Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Puesto__068DFC9EA6385ADE] PRIMARY KEY CLUSTERED 
(
	[Puesto_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sucursal]    Script Date: 25/9/2023 13:51:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sucursal](
	[Sucursal_ID] [int] IDENTITY(1,1) NOT NULL,
	[Sucursal] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Sucursal__372283B26E5E9B13] PRIMARY KEY CLUSTERED 
(
	[Sucursal_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SucursalxEmpleado]    Script Date: 25/9/2023 13:51:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SucursalxEmpleado](
	[Emp_ID] [int] NOT NULL,
	[Sucursal_ID] [int] NOT NULL,
	[Distancia_KM] [int] NOT NULL,
 CONSTRAINT [PK__Sucursal__155171B05B8D017F] PRIMARY KEY CLUSTERED 
(
	[Emp_ID] ASC,
	[Sucursal_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transportistas]    Script Date: 25/9/2023 13:51:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transportistas](
	[Trp_ID] [int] IDENTITY(1,1) NOT NULL,
	[Trp_Nombre] [varchar](50) NOT NULL,
	[Trp_Apellido] [varchar](50) NOT NULL,
	[Trp_Telefono] [varchar](15) NULL,
	[Trp_Tarifa] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK__Transpor__67B688BEF1699794] PRIMARY KEY CLUSTERED 
(
	[Trp_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 25/9/2023 13:51:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Usu_ID] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](20) NOT NULL,
	[Usu_clave] [varchar](50) NOT NULL,
	[Emp_ID] [int] NOT NULL,
	[Usu_activo] [bit] NOT NULL,
 CONSTRAINT [PK__Usuarios__B6173FEBB1705842] PRIMARY KEY CLUSTERED 
(
	[Usu_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Viajes]    Script Date: 25/9/2023 13:51:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Viajes](
	[Viaje_ID] [int] IDENTITY(1,1) NOT NULL,
	[Emp_ID] [int] NOT NULL,
	[Sucursal_ID] [int] NOT NULL,
	[Viaje_Fecha] [date] NOT NULL,
	[Trp_ID] [int] NOT NULL,
	[Viaje_Total] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK__Viajes__5D0F2E6CA4564BEE] PRIMARY KEY CLUSTERED 
(
	[Viaje_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Viajes_Detalle]    Script Date: 25/9/2023 13:51:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Viajes_Detalle](
	[VD_ID] [int] IDENTITY(1,1) NOT NULL,
	[Viaje_ID] [int] NULL,
	[Emp_ID] [int] NOT NULL,
	[Distancia_KM] [int] NOT NULL,
 CONSTRAINT [PK__Viajes_D__060692383B1C3F6F] PRIMARY KEY CLUSTERED 
(
	[VD_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Empleados] ON 

INSERT [dbo].[Empleados] ([Emp_ID], [Emp_identidad], [Emp_Nombre], [Emp_Apellido], [Emp_Direccion], [Emp_Telefono], [Puesto_ID], [Emp_transporte]) VALUES (2, N'0501200102223', N'Maria', N'Castro', N'Colonia Jose Paz', N'98789098', 1, 1)
INSERT [dbo].[Empleados] ([Emp_ID], [Emp_identidad], [Emp_Nombre], [Emp_Apellido], [Emp_Direccion], [Emp_Telefono], [Puesto_ID], [Emp_transporte]) VALUES (3, N'0987199823782', N'Jose', N'Reyes', N'Los zorzales', N'98765678', 2, 1)
SET IDENTITY_INSERT [dbo].[Empleados] OFF
GO
SET IDENTITY_INSERT [dbo].[Permiso] ON 

INSERT [dbo].[Permiso] ([Permiso_ID], [Puesto_ID], [NombreMenu]) VALUES (1, 2, N'MenuRegistro')
INSERT [dbo].[Permiso] ([Permiso_ID], [Puesto_ID], [NombreMenu]) VALUES (2, 2, N'MenuAdmin')
INSERT [dbo].[Permiso] ([Permiso_ID], [Puesto_ID], [NombreMenu]) VALUES (3, 2, N'MenuReporte')
INSERT [dbo].[Permiso] ([Permiso_ID], [Puesto_ID], [NombreMenu]) VALUES (7, 1, N'MenuAdmin')
INSERT [dbo].[Permiso] ([Permiso_ID], [Puesto_ID], [NombreMenu]) VALUES (8, 1, N'MenuReporte')
INSERT [dbo].[Permiso] ([Permiso_ID], [Puesto_ID], [NombreMenu]) VALUES (9, 1, N'MenuEmpleado')
INSERT [dbo].[Permiso] ([Permiso_ID], [Puesto_ID], [NombreMenu]) VALUES (10, 2, N'MenuEmpleado')
INSERT [dbo].[Permiso] ([Permiso_ID], [Puesto_ID], [NombreMenu]) VALUES (11, 1, N'MenuUsuario')
INSERT [dbo].[Permiso] ([Permiso_ID], [Puesto_ID], [NombreMenu]) VALUES (13, 2, N'MenuUsuario')
INSERT [dbo].[Permiso] ([Permiso_ID], [Puesto_ID], [NombreMenu]) VALUES (14, 1, N'MenuTransportista')
INSERT [dbo].[Permiso] ([Permiso_ID], [Puesto_ID], [NombreMenu]) VALUES (15, 2, N'MenuTransportista')
SET IDENTITY_INSERT [dbo].[Permiso] OFF
GO
SET IDENTITY_INSERT [dbo].[Puesto] ON 

INSERT [dbo].[Puesto] ([Puesto_ID], [Puesto_Nombre]) VALUES (1, N'Administrador')
INSERT [dbo].[Puesto] ([Puesto_ID], [Puesto_Nombre]) VALUES (2, N'Gerente de tienda')
SET IDENTITY_INSERT [dbo].[Puesto] OFF
GO
SET IDENTITY_INSERT [dbo].[Sucursal] ON 

INSERT [dbo].[Sucursal] ([Sucursal_ID], [Sucursal]) VALUES (1, N'Barrio Rio de Piedra')
INSERT [dbo].[Sucursal] ([Sucursal_ID], [Sucursal]) VALUES (2, N'Blv. del norte')
INSERT [dbo].[Sucursal] ([Sucursal_ID], [Sucursal]) VALUES (3, N'Blv. del este')
INSERT [dbo].[Sucursal] ([Sucursal_ID], [Sucursal]) VALUES (4, N'Colonia Santa Marta')
INSERT [dbo].[Sucursal] ([Sucursal_ID], [Sucursal]) VALUES (5, N'Sector Cofradia')
SET IDENTITY_INSERT [dbo].[Sucursal] OFF
GO
INSERT [dbo].[SucursalxEmpleado] ([Emp_ID], [Sucursal_ID], [Distancia_KM]) VALUES (2, 1, 15)
INSERT [dbo].[SucursalxEmpleado] ([Emp_ID], [Sucursal_ID], [Distancia_KM]) VALUES (2, 2, 28)
INSERT [dbo].[SucursalxEmpleado] ([Emp_ID], [Sucursal_ID], [Distancia_KM]) VALUES (2, 3, 20)
INSERT [dbo].[SucursalxEmpleado] ([Emp_ID], [Sucursal_ID], [Distancia_KM]) VALUES (3, 1, 86)
INSERT [dbo].[SucursalxEmpleado] ([Emp_ID], [Sucursal_ID], [Distancia_KM]) VALUES (3, 2, 16)
INSERT [dbo].[SucursalxEmpleado] ([Emp_ID], [Sucursal_ID], [Distancia_KM]) VALUES (3, 3, 24)
INSERT [dbo].[SucursalxEmpleado] ([Emp_ID], [Sucursal_ID], [Distancia_KM]) VALUES (3, 4, 20)
INSERT [dbo].[SucursalxEmpleado] ([Emp_ID], [Sucursal_ID], [Distancia_KM]) VALUES (3, 5, 10)
GO
SET IDENTITY_INSERT [dbo].[Transportistas] ON 

INSERT [dbo].[Transportistas] ([Trp_ID], [Trp_Nombre], [Trp_Apellido], [Trp_Telefono], [Trp_Tarifa]) VALUES (1, N'Mario', N'Tunes', N'98564367', CAST(20.00 AS Decimal(10, 2)))
INSERT [dbo].[Transportistas] ([Trp_ID], [Trp_Nombre], [Trp_Apellido], [Trp_Telefono], [Trp_Tarifa]) VALUES (2, N'Carlos', N'Martinez', N'23478987', CAST(18.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[Transportistas] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([Usu_ID], [Usuario], [Usu_clave], [Emp_ID], [Usu_activo]) VALUES (3, N'UPrueba', N'12345678', 2, 1)
INSERT [dbo].[Usuarios] ([Usu_ID], [Usuario], [Usu_clave], [Emp_ID], [Usu_activo]) VALUES (4, N'NReyes', N'10101010', 3, 1)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
SET IDENTITY_INSERT [dbo].[Viajes] ON 

INSERT [dbo].[Viajes] ([Viaje_ID], [Emp_ID], [Sucursal_ID], [Viaje_Fecha], [Trp_ID], [Viaje_Total]) VALUES (2, 3, 2, CAST(N'2023-09-25' AS Date), 2, CAST(50.00 AS Decimal(10, 2)))
INSERT [dbo].[Viajes] ([Viaje_ID], [Emp_ID], [Sucursal_ID], [Viaje_Fecha], [Trp_ID], [Viaje_Total]) VALUES (3, 3, 1, CAST(N'2023-09-25' AS Date), 1, CAST(86.00 AS Decimal(10, 2)))
INSERT [dbo].[Viajes] ([Viaje_ID], [Emp_ID], [Sucursal_ID], [Viaje_Fecha], [Trp_ID], [Viaje_Total]) VALUES (4, 3, 1, CAST(N'2023-09-25' AS Date), 1, CAST(86.00 AS Decimal(10, 2)))
INSERT [dbo].[Viajes] ([Viaje_ID], [Emp_ID], [Sucursal_ID], [Viaje_Fecha], [Trp_ID], [Viaje_Total]) VALUES (5, 3, 2, CAST(N'2023-09-25' AS Date), 1, CAST(16.00 AS Decimal(10, 2)))
INSERT [dbo].[Viajes] ([Viaje_ID], [Emp_ID], [Sucursal_ID], [Viaje_Fecha], [Trp_ID], [Viaje_Total]) VALUES (14, 3, 1, CAST(N'2023-09-25' AS Date), 1, CAST(86.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[Viajes] OFF
GO
SET IDENTITY_INSERT [dbo].[Viajes_Detalle] ON 

INSERT [dbo].[Viajes_Detalle] ([VD_ID], [Viaje_ID], [Emp_ID], [Distancia_KM]) VALUES (1, 2, 2, 10)
INSERT [dbo].[Viajes_Detalle] ([VD_ID], [Viaje_ID], [Emp_ID], [Distancia_KM]) VALUES (3, 14, 3, 86)
SET IDENTITY_INSERT [dbo].[Viajes_Detalle] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_Usuarios_Usuario]    Script Date: 25/9/2023 13:51:28 ******/
ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [UQ_Usuarios_Usuario] UNIQUE NONCLUSTERED 
(
	[Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK__Empleados__Puest__3B75D760] FOREIGN KEY([Puesto_ID])
REFERENCES [dbo].[Puesto] ([Puesto_ID])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK__Empleados__Puest__3B75D760]
GO
ALTER TABLE [dbo].[Permiso]  WITH CHECK ADD  CONSTRAINT [FK__Permiso__Puesto___38996AB5] FOREIGN KEY([Puesto_ID])
REFERENCES [dbo].[Puesto] ([Puesto_ID])
GO
ALTER TABLE [dbo].[Permiso] CHECK CONSTRAINT [FK__Permiso__Puesto___38996AB5]
GO
ALTER TABLE [dbo].[SucursalxEmpleado]  WITH CHECK ADD  CONSTRAINT [FK__Sucursalx__Sucur__440B1D61] FOREIGN KEY([Sucursal_ID])
REFERENCES [dbo].[Sucursal] ([Sucursal_ID])
GO
ALTER TABLE [dbo].[SucursalxEmpleado] CHECK CONSTRAINT [FK__Sucursalx__Sucur__440B1D61]
GO
ALTER TABLE [dbo].[SucursalxEmpleado]  WITH CHECK ADD  CONSTRAINT [FK_SucursalxEmpleado_Empleados] FOREIGN KEY([Emp_ID])
REFERENCES [dbo].[Empleados] ([Emp_ID])
GO
ALTER TABLE [dbo].[SucursalxEmpleado] CHECK CONSTRAINT [FK_SucursalxEmpleado_Empleados]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Empleados] FOREIGN KEY([Emp_ID])
REFERENCES [dbo].[Empleados] ([Emp_ID])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Empleados]
GO
ALTER TABLE [dbo].[Viajes]  WITH CHECK ADD  CONSTRAINT [FK__Viajes__Emp_ID__4CA06362] FOREIGN KEY([Emp_ID])
REFERENCES [dbo].[Empleados] ([Emp_ID])
GO
ALTER TABLE [dbo].[Viajes] CHECK CONSTRAINT [FK__Viajes__Emp_ID__4CA06362]
GO
ALTER TABLE [dbo].[Viajes]  WITH CHECK ADD  CONSTRAINT [FK__Viajes__Sucursal__4D94879B] FOREIGN KEY([Sucursal_ID])
REFERENCES [dbo].[Sucursal] ([Sucursal_ID])
GO
ALTER TABLE [dbo].[Viajes] CHECK CONSTRAINT [FK__Viajes__Sucursal__4D94879B]
GO
ALTER TABLE [dbo].[Viajes]  WITH CHECK ADD  CONSTRAINT [FK__Viajes__Trp_ID__4E88ABD4] FOREIGN KEY([Trp_ID])
REFERENCES [dbo].[Transportistas] ([Trp_ID])
GO
ALTER TABLE [dbo].[Viajes] CHECK CONSTRAINT [FK__Viajes__Trp_ID__4E88ABD4]
GO
ALTER TABLE [dbo].[Viajes_Detalle]  WITH CHECK ADD  CONSTRAINT [FK__Viajes_De__Viaje__5165187F] FOREIGN KEY([Viaje_ID])
REFERENCES [dbo].[Viajes] ([Viaje_ID])
GO
ALTER TABLE [dbo].[Viajes_Detalle] CHECK CONSTRAINT [FK__Viajes_De__Viaje__5165187F]
GO
/****** Object:  StoredProcedure [dbo].[AgregarEmpleadoxSucursal]    Script Date: 25/9/2023 13:51:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarEmpleadoxSucursal]
    @Emp_ID INT,
    @Sucursal_ID INT,
    @Distancia_KM INT
AS
BEGIN
    INSERT INTO dbo.SucursalxEmpleado (Emp_ID, Sucursal_ID, Distancia_KM)
    VALUES (@Emp_ID, @Sucursal_ID, @Distancia_KM);
END
GO
/****** Object:  StoredProcedure [dbo].[BuscarEmpleado]    Script Date: 25/9/2023 13:51:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuscarEmpleado]
    @Emp_ID INT
AS
BEGIN
    SELECT Emp_ID, Emp_Nombre, Emp_Apellido
    FROM dbo.Empleados
    WHERE Emp_ID = @Emp_ID;
END
GO
/****** Object:  StoredProcedure [dbo].[BuscarSucursales]    Script Date: 25/9/2023 13:51:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuscarSucursales]
AS
BEGIN
    SELECT * FROM dbo.Sucursal;
END
GO
/****** Object:  StoredProcedure [dbo].[BuscarUsuario]    Script Date: 25/9/2023 13:51:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuscarUsuario]
    @Usuario NVARCHAR(20)
AS
BEGIN
    SELECT *
    FROM dbo.Usuarios
    WHERE Usuario = @Usuario;
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarDetalleViaje]    Script Date: 25/9/2023 13:51:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarDetalleViaje]
    @Viaje_ID INT,
    @Emp_ID INT,
    @Distancia_KM INT
AS
BEGIN
    INSERT INTO dbo.Viajes_Detalle (Viaje_ID, Emp_ID, Distancia_KM)
    VALUES (@Viaje_ID, @Emp_ID, @Distancia_KM);
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarViaje]    Script Date: 25/9/2023 13:51:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarViaje]
    @Emp_ID INT,
    @Sucursal_ID INT,
    @Trp_ID INT,
    @Viaje_Total DECIMAL(10, 2)
AS
BEGIN
    -- Obtener la fecha actual sin la hora
    DECLARE @FechaActual DATE = CAST(GETDATE() AS DATE);

    INSERT INTO dbo.Viajes (Emp_ID, Sucursal_ID, Viaje_Fecha, Trp_ID, Viaje_Total)
    VALUES (@Emp_ID, @Sucursal_ID, @FechaActual, @Trp_ID, @Viaje_Total);

    -- Obtener el ID del viaje recién insertado usando SELECT
    SELECT SCOPE_IDENTITY() AS Viaje_ID;
END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerEmpleadosConTransporte]    Script Date: 25/9/2023 13:51:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerEmpleadosConTransporte]
AS
BEGIN
    SELECT Emp_ID, Emp_Nombre, Emp_Apellido
    FROM dbo.Empleados
    WHERE Emp_transporte = 1; -- Filtra por empleados con Emp_transporte = true
END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerEmpleadosPorSucursal]    Script Date: 25/9/2023 13:51:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerEmpleadosPorSucursal]
    @Sucursal_ID INT
AS
BEGIN
    SELECT e.Emp_ID, e.Emp_Nombre, e.Emp_Apellido, se.Distancia_KM
    FROM dbo.Empleados e
    INNER JOIN dbo.SucursalxEmpleado se ON e.Emp_ID = se.Emp_ID
    WHERE se.Sucursal_ID = @Sucursal_ID;
END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerNOSucursales]    Script Date: 25/9/2023 13:51:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerNOSucursales]
    @Emp_ID INT
AS
BEGIN
    SELECT s.Sucursal_ID, s.Sucursal, se.Distancia_KM
    FROM dbo.Sucursal s
    INNER JOIN dbo.SucursalxEmpleado se ON s.Sucursal_ID = se.Sucursal_ID
    WHERE se.Emp_ID = 2;
END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerSucursales]    Script Date: 25/9/2023 13:51:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerSucursales]
    @Emp_ID INT
AS
BEGIN
    SELECT s.Sucursal_ID, s.Sucursal, se.Distancia_KM
    FROM dbo.Sucursal s
    INNER JOIN dbo.SucursalxEmpleado se ON s.Sucursal_ID = se.Sucursal_ID
    WHERE se.Emp_ID = @Emp_ID;
END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerSucursalesNoVinculadas]    Script Date: 25/9/2023 13:51:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerSucursalesNoVinculadas]
    @Emp_ID INT
AS
BEGIN
    SELECT s.Sucursal_ID, s.Sucursal
    FROM dbo.Sucursal s
    LEFT JOIN dbo.SucursalxEmpleado se ON s.Sucursal_ID = se.Sucursal_ID AND se.Emp_ID = @Emp_ID
    WHERE se.Emp_ID IS NULL;
END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerTransportistas]    Script Date: 25/9/2023 13:51:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerTransportistas]
AS
BEGIN
    SELECT * FROM dbo.Transportistas;
END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerViajesPorFechaYTransportista]    Script Date: 25/9/2023 13:51:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerViajesPorFechaYTransportista]
    @FechaInicio DATE,
    @FechaFin DATE,
    @Trp_ID INT
AS
BEGIN
    SELECT
        V.Viaje_ID,
        E.Emp_Nombre AS NombreEmpleado,
        E.Emp_Apellido AS ApellidoEmpleado,
        S.Sucursal AS NombreSucursal,
        V.Viaje_Fecha AS Fecha,
        V.Viaje_Total AS ViajeTotal,
        (V.Viaje_Total * T.Trp_Tarifa) AS TotalCalculado
    FROM
        dbo.Viajes V
    INNER JOIN
        dbo.Empleados E ON V.Emp_ID = E.Emp_ID
    INNER JOIN
        dbo.Sucursal S ON V.Sucursal_ID = S.Sucursal_ID
    INNER JOIN
        dbo.Transportistas T ON V.Trp_ID = T.Trp_ID
    WHERE
        V.Viaje_Fecha >= @FechaInicio
        AND V.Viaje_Fecha <= @FechaFin
        AND T.Trp_ID = @Trp_ID;
END
GO
/****** Object:  StoredProcedure [dbo].[PermisosPorEmpleado]    Script Date: 25/9/2023 13:51:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PermisosPorEmpleado]
    @Emp_ID INT
AS
BEGIN
    SELECT p.Puesto_ID, p.NombreMenu
    FROM Permiso p
    INNER JOIN Puesto pu ON pu.Puesto_ID = p.Puesto_ID
    INNER JOIN Empleados e ON e.Puesto_ID = pu.Puesto_ID
    WHERE e.Emp_ID = @Emp_ID;
END
GO
/****** Object:  StoredProcedure [dbo].[Usuarios_Listar]    Script Date: 25/9/2023 13:51:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuarios_Listar] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	
    -- Insert statements for procedure here
	SELECT * FROM dbo.Usuarios;
END
GO
/****** Object:  StoredProcedure [dbo].[VerificarEmpleadoFecha]    Script Date: 25/9/2023 13:51:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VerificarEmpleadoFecha]
    @Emp_ID INT
AS
BEGIN
    DECLARE @ContadorViajes INT;

    -- Verificar si el empleado realizó un viaje en la fecha especificada
    SELECT @ContadorViajes = COUNT(*)
    FROM dbo.Viajes_Detalle
    WHERE Emp_ID = @Emp_ID AND EXISTS (
        SELECT 1
        FROM dbo.Viajes
        WHERE Viajes.Viaje_ID = Viajes_Detalle.Viaje_ID
              AND Viaje_Fecha = CAST(GETDATE() AS DATE)
    );

    -- Retorna 1 si el empleado realizó un viaje, 0 en caso contrario
    IF @ContadorViajes > 0
        SELECT 1 AS RealizoViaje;
    ELSE
        SELECT 0 AS RealizoViaje;
END
GO
