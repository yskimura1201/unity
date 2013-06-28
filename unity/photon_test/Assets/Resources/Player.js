#pragma strict
var joystick : Joystick;
private var moveDirection : Vector3 = Vector3.zero;

function Start () {
	joystick = FindObjectOfType(Joystick) as Joystick;
	animation['Walk'].speed = 1.0;
}

function Update () {
	var controller = GetComponent(CharacterController);
	
	var targetDirection : Vector3 = Vector3(joystick.position.x, 0, joystick.position.y);
	if (targetDirection.magnitude > 0.1) {
		transform.rotation = Quaternion.LookRotation(targetDirection);
		moveDirection += transform.forward*0.05;
		animation.CrossFade("walk");
	} else {
		animation.CrossFade("idle");
	}
	controller.Move(moveDirection*Time.deltaTime);

}
