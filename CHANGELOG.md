# Historial de versiones

## v1.0.2 (26/11/2026)
- Corrección del error de la versión v1.0.1: MostrarInformacion() vuelve a imprimir el nombre real del producto (PR #32).
- Validación satisfactoria de la funcionalidad Producto con 7 de 7 pruebas.
- Liberación publicada en GitHub Releases con el paquete sistema-inventario-v1.0.2.zip.

## v1.0.1 (26/11/2026)
- Corrección del workflow de liberación para ejecutar las pruebas sin --no-restore (PR #30).
- Error intencional en MostrarInformacion() para comprobar el proceso de liberación (PR #31): fallaron las pruebas CP03 y CP06.
- La liberación se detuvo en el paso "Ejecutar pruebas" y no se publicó ningún Release. La etiqueta se conserva y no se reutiliza.

## v1.0.0 (26/11/2026)
- Primera versión del Sistema de Inventario.
- Incorporación de la funcionalidad Producto y de la búsqueda de productos por nombre.
- Implementación de 7 pruebas automatizadas con xUnit.
- Workflows de GitHub Actions para pruebas, compilación y liberación.