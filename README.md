# Flappy_Bird

משחק זה מדמה את המשחק "Flappy Bird".

במשחק נדרש ללחוץ על "space" כדי להשאיר את הציפור עפה. השחקן נפסל כאשר הציפור תיפול אל התהום או כאשר תתנגש באחד הצינורות במסך:


 ![Screenshot 2024-01-23 144040](https://github.com/AdiNahmias/Flappy_Bird/assets/118722490/8c1bc3b9-90bd-453f-9df6-0cf206144a0c)



תפקיד המחלקה BirdScript הוא לקבוע את תנועת הציפור.

BirsScript - [click here](https://github.com/AdiNahmias/Flappy_Bird/blob/main/Assets/Scripts/BirdScript.cs)

תפקיד המחקלה PipeMover הוא ליצור תזוזה לאורך המסך במהירות מסויימת. 

PipeMover script - [click here](https://github.com/AdiNahmias/Flappy_Bird/blob/main/Assets/Scripts/PipeMover.cs)

תפקיד המחקלה PipeSpawner הוא ליצור צינורת חדשים בגבהים שונים לאורך המסך.

PipeSpawner script - [click here](https://github.com/AdiNahmias/Flappy_Bird/blob/main/Assets/Scripts/PipeSpawner.cs)

תפקיד המחלקה PipeMiddle הוא לעזור לנו בספירת הניקוד, כאשר הציפור תתנגש באיזור שבין 2 צינורות סימן שהיא לא התנגשה בצינור ולכן הניקוד שלה יעלה בנקודה.

PipeMiddle script - [click here](https://github.com/AdiNahmias/Flappy_Bird/blob/main/Assets/Scripts/PipeMiddleScript.cs)

תפקיד המחלקה DistroyOnTrigger2D הוא להשמיד את הציפור ברגע שהיא מתנגשת בצינור.

DistroyOnTrigger2D script - [click here](https://github.com/AdiNahmias/Flappy_Bird/blob/main/Assets/Scripts/DestroyOnTrigger2D.cs)



בכדי לשחק במשחק [לחץ כאן](https://adinahmias.itch.io/flapp)







