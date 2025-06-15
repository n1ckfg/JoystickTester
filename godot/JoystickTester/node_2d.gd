extends Node2D

func _ready():
	print("Monitoring joystick input... (Press joystick buttons or move axes)")
	set_process_input(true)

func _input(event):
	if event is InputEventJoypadButton:
		if event.pressed:
			print("Joystick: " + str(event.device) + ", Button Pressed: " + str(event.button_index))
		else:
			print("Joystick: " + str(event.device) + ", Button Released: " + str(event.button_index))

	if event is InputEventJoypadMotion:
		if abs(event.axis_value) > 0.1: # Threshold to prevent noise
			print("Joystick: " + str(event.device) + ", Axis: " + str(event.axis) + ", Motion: " + str(event.axis_value))

# You can also poll joystick state in _process or _physics_process for continuous updates.
# Polling in _input is better for event-driven responses.
func _process(delta):
	 # Polling an axis
	var joy_0_lx = Input.get_joy_axis(0, JOY_AXIS_LEFT_X)
	if abs(joy_0_lx) > 0.1:
		print("Polling Joystick 0 Left X-axis " + str(joy_0_lx))

	 # Polling a button
	#if Input.is_joy_button_pressed(0, JOY_BUTTON_0):
		#print("Polling Joystick 0 Button 0 is pressed!")
