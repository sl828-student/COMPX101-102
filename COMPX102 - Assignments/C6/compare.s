.text
.global main
main:
	# Get the address of the welcome message
	la	$2, welcome_msg
	# Display the message
	jal	putstr
    # Clear our first register
	add	$4, $0, $0
	#Clear our second register
	jal readnum
	
	add $4, $0, $1
	
	la $2, secondNum_msg
	
	jal putstr
	
	jal readnum
	
	add $5, $0, $1
	
	sgt $6, $4, $5
	
	bnez $6, greater
	
	beqz $6, lesser
	
greater:
	
	la $2, greater_msg
	
	jal putstr
	
	add $2, $0, $4

	jal writenum
	
	j exit
	
	
lesser:
	
	la $2, greater_msg
	
	jal putstr
	
	
	add $2, $0, $5
	
	jal writenum
	
	j exit
	
	
	
	
	

.data
	# This is our welcome message
welcome_msg:
	.asciiz	"Please type a number you would like to be compared to another: "
	
secondNum_msg:
	.asciiz "Please type the second number you would like compared: "
	
greater_msg:
	.asciiz "The larger number is: "
	
