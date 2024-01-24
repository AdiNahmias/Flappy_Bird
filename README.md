# Flappy_Bird

משחק זה מדמה את המשחק "Flappy Bird".

במשחק נדרש ללחוץ על "space" כדי להשאיר את הציפור עפה. השחקן נפסל כאשר הציפור תיפול אל התהום או כאשר תתנגש באחד הצינורות במסך:

![image](https://github.com/AdiNahmias/Flappy_Bird/assets/118722490/e28e2202-7fda-4d37-ba0f-16b158c751a3)




תפקיד המחקלה PipeMover הוא ליצור צינורות הזזים לאורך המסך במהירות מסויימת. 

PipeMover script - [click here](https://github.com/AdiNahmias/Flappy_Bird/blob/main/Assets/Scripts/PipeMover.cs)

תפקיד המחקלה PipeSpawner הוא ליצור צינואות בגבהים שונים לאורך המסך (הגובה של הצינור התחתון יהיה שונה מזה של העליון).

PipeSpawner script - [click here](https://github.com/AdiNahmias/Flappy_Bird/blob/main/Assets/Scripts/PipeSpawner.cs)

תפקיד המחלקה PipeMiddle הוא לעזור לנו בספירת הניקוד, כאשר הציפור תתנגש באיזור שבין 2 צינורות סימן שהיא לא התנגשה בצינור ולכן הניקוד שלה יעלה בנקודה.

PipeMiddle script - [click here](https://github.com/AdiNahmias/Flappy_Bird/blob/main/Assets/Scripts/PipeMiddleScript.cs)

תפקיד המחלקה DistroyOnTrigger2D הוא להשמיד את הציפור ברגע שהיא מתנגשת בצינור.

DistroyOnTrigger2D script - [click here](https://github.com/AdiNahmias/Flappy_Bird/blob/main/Assets/Scripts/DestroyOnTrigger2D.cs)



בכדי לשחק במשחק [https://adinahmias.itch.io/flap] (לחץ כאן)







