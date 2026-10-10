# Ejercicios Físicas 3D - Scripts

Autor: Javier Acosta Portocarrero

En esta práctica he aprendido a trabajar con las físicas 3D de Unity, especialmente con los componentes `Rigidbody` y `Collider`, además de ver las diferencias entre colisiones normales, triggers y aprender a usar materiales físicos y layers. También he trabajado con nuevas funciones relacionadas con físicas y con distintas formas de detectar interacciones entre objetos.

## Ejercicio 1

En este ejercicio aprendí a mover un personaje usando un `Rigidbody` libremente, para lo cual es necesario activer la opción de `IsKinematic` para que las físicas y las colisiones no afecten a su posción. Para esto se siguen leyendo los inputs `Horizontal` y `Vertical`.
También aprendí la importancia de `FixedUpdate`, que es más apropiado que `Update` para realizar operaciones relacionadas con físicas, ya que se ejecuta a intervalos constantes.

Prueba de ejecución de este ejercicio:  
![Gif Ejercicio 1](./gifs_readme2/p2-ejercicio1.gif)

## Ejercicio 2

Este ejercicio me enseñó a detectar colisiones entre objetos usando `OnCollisionEnter`. A partir del objeto `Collision` (parámetro del método anterior) se puede acceder al GameObject con el que se ha producido la colisión y, por ejemplo, mostrar su nombre por consola.

Además, al producirse la colisión se modifica el color del objeto obteniendo su componente `Renderer` mediante `GetComponent`. Esto me ayudó a entender mejor cómo interactúan entre sí los objetos con `Collider` y `Rigidbody`.

Prueba de ejecución de este ejercicio:  
![Gif Ejercicio 2](./gifs_readme2/p2-ejercicio2.gif)

## Ejercicio 3

En este ejercicio aprendí a trabajar con `Triggers`, activando `Is Trigger` en un Collider. Esto me ha permitido detectar cuándo un objeto entra o sale de una zona sin producir una colisión física normal, usando `OnTriggerEnter` y `OnTriggerExit`.

Se utilizó una zona para cambiar temporalmente el color del jugador y otra para aumentar una variable de daño almacenada en el propio personaje. Esto me permitió entender mejor la diferencia entre una colisión normal y una zona de detección.

Prueba de ejecución de este ejercicio:  
![Gif Ejercicio 3](./gifs_readme2/p2-ejercicio3.gif)

## Ejercicio 4

Este ejercicio introduce el uso de las `Layers` y de la `Layer Collision Matrix`, que permite decidir qué grupos de objetos pueden interactuar entre sí. Se crearon capas distintas para el jugador, los enemigos y los recolectables.

Los enemigos se configuraron para colisionar con el jugador, mientras que los recolectables utilizan `Is Trigger` para poder ser atravesados y detectados mediante `OnTriggerEnter`. También se usó `CompareTag` para comprobar que el objeto que entra en el trigger del coleccionable es el jugador, para así, en `OnTriggerEnter`, destruir el objeto y mostar un mensaje por consola.

Prueba de ejecución de este ejercicio:  
![Gif Ejercicio 4](./gifs_readme2/p2-ejercicio4.gif)

## Ejercicio 5

En este ejercicio aprendí a utilizar `Physic Materials`, modificando propiedades como la fricción y el `Bounciness` para crear superficies u objetos resbaladizos, rugosos o con mucho rebote. También he usado la configuración de Input Manager para asociar una tecla al input `Fire1`.

También aprendí a aplicar fuerzas mediante `Rigidbody.AddForce`, utilizando `ForceMode.Impulse` para lanzar los objetos al activar el input `Fire1`. La lectura del input se realiza en `Update`, mientras que la fuerza se aplica en `FixedUpdate`.

Se ha observado que para el objeto con mayor fricción, al aplicar la fuerza se desliza de forma más lenta que los demás, mientras que el objeto con menor fricción se desliza más rápido. Además, el objeto con mayor rebote es el único que realmente se eleva al chocar contra la pared del fondo, rebotando y volviendo a caer en el suelo.

Prueba de ejecución de este ejercicio:  
![Gif Ejercicio 5](./gifs_readme2/p2-ejercicio5.gif)

## Ejercicio 6

En este ejercicio la esfera debe dirigirse hacia un cilindro usando `Vector3.MoveTowards`, mientras que un cubo actúa como obstáculo. Tanto el objetivo como el obstáculo se buscan mediante Tags, permitiendo evitar referencias directas desde el Inspector.

Lo más destacable de este ejercicio ha sido comprobar lo complicado que resulta detectar manualmente las colisiones cuando ningún objeto tiene `Rigidbody`. Al no poder utilizar directamente `OnCollisionEnter`, fue necesario obtener los Collider de los objetos y comprobar manualmente si sus límites se intersectaban usando `bounds.Intersects`. Esto me hizo valorar bastante la facilidad que ofrece el sistema de físicas de Unity cuando se utilizan `Rigidbody`.

Prueba de ejecución de este ejercicio:  
![Gif Ejercicio 6](./gifs_readme2/p2-ejercicio6.gif)