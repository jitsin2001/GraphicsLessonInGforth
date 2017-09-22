\ ===================================================================
\      Program: glconstants.fs
\  Description: OpenGL constants definitions
\ Forth System: gforth-0.7.0
\ ===================================================================

1	constant GL_VERSION_1_1
1	constant GL_VERSION_1_2
1	constant GL_VERSION_1_3
1	constant GL_ARB_imaging
$0	constant GL_FALSE
$1	constant GL_TRUE
$1400	constant GL_BYTE
$1401	constant GL_UNSIGNED_BYTE
$1402	constant GL_SHORT
$1403	constant GL_UNSIGNED_SHORT
$1404	constant GL_INT
$1405	constant GL_UNSIGNED_INT
$1406	constant GL_FLOAT
$1407	constant GL_2_BYTES
$1408	constant GL_3_BYTES
$1409	constant GL_4_BYTES
$140A	constant GL_DOUBLE
$0000	constant GL_POINTS
$0001	constant GL_LINES
$0002	constant GL_LINE_LOOP
$0003	constant GL_LINE_STRIP
$0004	constant GL_TRIANGLES
$0005	constant GL_TRIANGLE_STRIP
$0006	constant GL_TRIANGLE_FAN
$0007	constant GL_QUADS
$0008	constant GL_QUAD_STRIP
$0009	constant GL_POLYGON
$8074	constant GL_VERTEX_ARRAY
$8075	constant GL_NORMAL_ARRAY
$8076	constant GL_COLOR_ARRAY
$8077	constant GL_INDEX_ARRAY
$8078	constant GL_TEXTURE_COORD_ARRAY
$8079	constant GL_EDGE_FLAG_ARRAY
$807A	constant GL_VERTEX_ARRAY_SIZE
$807B	constant GL_VERTEX_ARRAY_TYPE
$807C	constant GL_VERTEX_ARRAY_STRIDE
$807E	constant GL_NORMAL_ARRAY_TYPE
$807F	constant GL_NORMAL_ARRAY_STRIDE
$8081	constant GL_COLOR_ARRAY_SIZE
$8082	constant GL_COLOR_ARRAY_TYPE
$8083	constant GL_COLOR_ARRAY_STRIDE
$8085	constant GL_INDEX_ARRAY_TYPE
$8086	constant GL_INDEX_ARRAY_STRIDE
$8088	constant GL_TEXTURE_COORD_ARRAY_SIZE
$8089	constant GL_TEXTURE_COORD_ARRAY_TYPE
$808A	constant GL_TEXTURE_COORD_ARRAY_STRIDE
$808C	constant GL_EDGE_FLAG_ARRAY_STRIDE
$808E	constant GL_VERTEX_ARRAY_POINTER
$808F	constant GL_NORMAL_ARRAY_POINTER
$8090	constant GL_COLOR_ARRAY_POINTER
$8091	constant GL_INDEX_ARRAY_POINTER
$8092	constant GL_TEXTURE_COORD_ARRAY_POINTER
$8093	constant GL_EDGE_FLAG_ARRAY_POINTER
$2A20	constant GL_V2F
$2A21	constant GL_V3F
$2A22	constant GL_C4UB_V2F
$2A23	constant GL_C4UB_V3F
$2A24	constant GL_C3F_V3F
$2A25	constant GL_N3F_V3F
$2A26	constant GL_C4F_N3F_V3F
$2A27	constant GL_T2F_V3F
$2A28	constant GL_T4F_V4F
$2A29	constant GL_T2F_C4UB_V3F
$2A2A	constant GL_T2F_C3F_V3F
$2A2B	constant GL_T2F_N3F_V3F
$2A2C	constant GL_T2F_C4F_N3F_V3F
$2A2D	constant GL_T4F_C4F_N3F_V4F
$0BA0	constant GL_MATRIX_MODE
$1700	constant GL_MODELVIEW
$1701	constant GL_PROJECTION
$1702	constant GL_TEXTURE
$0B10	constant GL_POINT_SMOOTH
$0B11	constant GL_POINT_SIZE
$0B13	constant GL_POINT_SIZE_GRANULARITY
$0B12	constant GL_POINT_SIZE_RANGE
$0B20	constant GL_LINE_SMOOTH
$0B24	constant GL_LINE_STIPPLE
$0B25	constant GL_LINE_STIPPLE_PATTERN
$0B26	constant GL_LINE_STIPPLE_REPEAT
$0B21	constant GL_LINE_WIDTH
$0B23	constant GL_LINE_WIDTH_GRANULARITY
$0B22	constant GL_LINE_WIDTH_RANGE
$1B00	constant GL_POINT
$1B01	constant GL_LINE
$1B02	constant GL_FILL
$0900	constant GL_CW
$0901	constant GL_CCW
$0404	constant GL_FRONT
$0405	constant GL_BACK
$0B40	constant GL_POLYGON_MODE
$0B41	constant GL_POLYGON_SMOOTH
$0B42	constant GL_POLYGON_STIPPLE
$0B43	constant GL_EDGE_FLAG
$0B44	constant GL_CULL_FACE
$0B45	constant GL_CULL_FACE_MODE
$0B46	constant GL_FRONT_FACE
$8038	constant GL_POLYGON_OFFSET_FACTOR
$2A00	constant GL_POLYGON_OFFSET_UNITS
$2A01	constant GL_POLYGON_OFFSET_POINT
$2A02	constant GL_POLYGON_OFFSET_LINE
$8037	constant GL_POLYGON_OFFSET_FILL
$1300	constant GL_COMPILE
$1301	constant GL_COMPILE_AND_EXECUTE
$0B32	constant GL_LIST_BASE
$0B33	constant GL_LIST_INDEX
$0B30	constant GL_LIST_MODE
$0200	constant GL_NEVER
$0201	constant GL_LESS
$0202	constant GL_EQUAL
$0203	constant GL_LEQUAL
$0204	constant GL_GREATER
$0205	constant GL_NOTEQUAL
$0206	constant GL_GEQUAL
$0207	constant GL_ALWAYS
$0B71	constant GL_DEPTH_TEST
$0D56	constant GL_DEPTH_BITS
$0B73	constant GL_DEPTH_CLEAR_VALUE
$0B74	constant GL_DEPTH_FUNC
$0B70	constant GL_DEPTH_RANGE
$0B72	constant GL_DEPTH_WRITEMASK
$1902	constant GL_DEPTH_COMPONENT
$0B50	constant GL_LIGHTING
$4000	constant GL_LIGHT0
$4001	constant GL_LIGHT1
$4002	constant GL_LIGHT2
$4003	constant GL_LIGHT3
$4004	constant GL_LIGHT4
$4005	constant GL_LIGHT5
$4006	constant GL_LIGHT6
$4007	constant GL_LIGHT7
$1205	constant GL_SPOT_EXPONENT
$1206	constant GL_SPOT_CUTOFF
$1207	constant GL_CONSTANT_ATTENUATION
$1208	constant GL_LINEAR_ATTENUATION
$1209	constant GL_QUADRATIC_ATTENUATION
$1200	constant GL_AMBIENT
$1201	constant GL_DIFFUSE
$1202	constant GL_SPECULAR
$1601	constant GL_SHININESS
$1600	constant GL_EMISSION
$1203	constant GL_POSITION
$1204	constant GL_SPOT_DIRECTION
$1602	constant GL_AMBIENT_AND_DIFFUSE
$1603	constant GL_COLOR_INDEXES
$0B52	constant GL_LIGHT_MODEL_TWO_SIDE
$0B51	constant GL_LIGHT_MODEL_LOCAL_VIEWER
$0B53	constant GL_LIGHT_MODEL_AMBIENT
$0408	constant GL_FRONT_AND_BACK
$0B54	constant GL_SHADE_MODEL
$1D00	constant GL_FLAT
$1D01	constant GL_SMOOTH
$0B57	constant GL_COLOR_MATERIAL
$0B55	constant GL_COLOR_MATERIAL_FACE
$0B56	constant GL_COLOR_MATERIAL_PARAMETER
$0BA1	constant GL_NORMALIZE
$3000	constant GL_CLIP_PLANE0
$3001	constant GL_CLIP_PLANE1
$3002	constant GL_CLIP_PLANE2
$3003	constant GL_CLIP_PLANE3
$3004	constant GL_CLIP_PLANE4
$3005	constant GL_CLIP_PLANE5
$0D58	constant GL_ACCUM_RED_BITS
$0D59	constant GL_ACCUM_GREEN_BITS
$0D5A	constant GL_ACCUM_BLUE_BITS
$0D5B	constant GL_ACCUM_ALPHA_BITS
$0B80	constant GL_ACCUM_CLEAR_VALUE
$0100	constant GL_ACCUM
$0104	constant GL_ADD
$0101	constant GL_LOAD
$0103	constant GL_MULT
$0102	constant GL_RETURN
$0BC0	constant GL_ALPHA_TEST
$0BC2	constant GL_ALPHA_TEST_REF
$0BC1	constant GL_ALPHA_TEST_FUNC
$0BE2	constant GL_BLEND
$0BE1	constant GL_BLEND_SRC
$0BE0	constant GL_BLEND_DST
$0	constant GL_ZERO
$1	constant GL_ONE
$0300	constant GL_SRC_COLOR
$0301	constant GL_ONE_MINUS_SRC_COLOR
$0302	constant GL_SRC_ALPHA
$0303	constant GL_ONE_MINUS_SRC_ALPHA
$0304	constant GL_DST_ALPHA
$0305	constant GL_ONE_MINUS_DST_ALPHA
$0306	constant GL_DST_COLOR
$0307	constant GL_ONE_MINUS_DST_COLOR
$0308	constant GL_SRC_ALPHA_SATURATE
$1C01	constant GL_FEEDBACK
$1C00	constant GL_RENDER
$1C02	constant GL_SELECT
$0600	constant GL_2D
$0601	constant GL_3D
$0602	constant GL_3D_COLOR
$0603	constant GL_3D_COLOR_TEXTURE
$0604	constant GL_4D_COLOR_TEXTURE
$0701	constant GL_POINT_TOKEN
$0702	constant GL_LINE_TOKEN
$0707	constant GL_LINE_RESET_TOKEN
$0703	constant GL_POLYGON_TOKEN
$0704	constant GL_BITMAP_TOKEN
$0705	constant GL_DRAW_PIXEL_TOKEN
$0706	constant GL_COPY_PIXEL_TOKEN
$0700	constant GL_PASS_THROUGH_TOKEN
$0DF0	constant GL_FEEDBACK_BUFFER_POINTER
$0DF1	constant GL_FEEDBACK_BUFFER_SIZE
$0DF2	constant GL_FEEDBACK_BUFFER_TYPE
$0DF3	constant GL_SELECTION_BUFFER_POINTER
$0DF4	constant GL_SELECTION_BUFFER_SIZE
$0B60	constant GL_FOG
$0B65	constant GL_FOG_MODE
$0B62	constant GL_FOG_DENSITY
$0B66	constant GL_FOG_COLOR
$0B61	constant GL_FOG_INDEX
$0B63	constant GL_FOG_START
$0B64	constant GL_FOG_END
$2601	constant GL_LINEAR
$0800	constant GL_EXP
$0801	constant GL_EXP2
$0BF1	constant GL_LOGIC_OP
$0BF1	constant GL_INDEX_LOGIC_OP
$0BF2	constant GL_COLOR_LOGIC_OP
$0BF0	constant GL_LOGIC_OP_MODE
$1500	constant GL_CLEAR
$150F	constant GL_SET
$1503	constant GL_COPY
$150C	constant GL_COPY_INVERTED
$1505	constant GL_NOOP
$150A	constant GL_INVERT
$1501	constant GL_AND
$150E	constant GL_NAND
$1507	constant GL_OR
$1508	constant GL_NOR
$1506	constant GL_XOR
$1509	constant GL_EQUIV
$1502	constant GL_AND_REVERSE
$1504	constant GL_AND_INVERTED
$150B	constant GL_OR_REVERSE
$150D	constant GL_OR_INVERTED
$0D57	constant GL_STENCIL_BITS
$0B90	constant GL_STENCIL_TEST
$0B91	constant GL_STENCIL_CLEAR_VALUE
$0B92	constant GL_STENCIL_FUNC
$0B93	constant GL_STENCIL_VALUE_MASK
$0B94	constant GL_STENCIL_FAIL
$0B95	constant GL_STENCIL_PASS_DEPTH_FAIL
$0B96	constant GL_STENCIL_PASS_DEPTH_PASS
$0B97	constant GL_STENCIL_REF
$0B98	constant GL_STENCIL_WRITEMASK
$1901	constant GL_STENCIL_INDEX
$1E00	constant GL_KEEP
$1E01	constant GL_REPLACE
$1E02	constant GL_INCR
$1E03	constant GL_DECR
$0	constant GL_NONE
$0406	constant GL_LEFT
$0407	constant GL_RIGHT
$0400	constant GL_FRONT_LEFT
$0401	constant GL_FRONT_RIGHT
$0402	constant GL_BACK_LEFT
$0403	constant GL_BACK_RIGHT
$0409	constant GL_AUX0
$040A	constant GL_AUX1
$040B	constant GL_AUX2
$040C	constant GL_AUX3
$1900	constant GL_COLOR_INDEX
$1903	constant GL_RED
$1904	constant GL_GREEN
$1905	constant GL_BLUE
$1906	constant GL_ALPHA
$1909	constant GL_LUMINANCE
$190A	constant GL_LUMINANCE_ALPHA
$0D55	constant GL_ALPHA_BITS
$0D52	constant GL_RED_BITS
$0D53	constant GL_GREEN_BITS
$0D54	constant GL_BLUE_BITS
$0D51	constant GL_INDEX_BITS
$0D50	constant GL_SUBPIXEL_BITS
$0C00	constant GL_AUX_BUFFERS
$0C02	constant GL_READ_BUFFER
$0C01	constant GL_DRAW_BUFFER
$0C32	constant GL_DOUBLEBUFFER
$0C33	constant GL_STEREO
$1A00	constant GL_BITMAP
$1800	constant GL_COLOR
$1801	constant GL_DEPTH
$1802	constant GL_STENCIL
$0BD0	constant GL_DITHER
$1907	constant GL_RGB
$1908	constant GL_RGBA
$0B31	constant GL_MAX_LIST_NESTING
$0D30	constant GL_MAX_EVAL_ORDER
$0D31	constant GL_MAX_LIGHTS
$0D32	constant GL_MAX_CLIP_PLANES
$0D33	constant GL_MAX_TEXTURE_SIZE
$0D34	constant GL_MAX_PIXEL_MAP_TABLE
$0D35	constant GL_MAX_ATTRIB_STACK_DEPTH
$0D36	constant GL_MAX_MODELVIEW_STACK_DEPTH
$0D37	constant GL_MAX_NAME_STACK_DEPTH
$0D38	constant GL_MAX_PROJECTION_STACK_DEPTH
$0D39	constant GL_MAX_TEXTURE_STACK_DEPTH
$0D3A	constant GL_MAX_VIEWPORT_DIMS
$0D3B	constant GL_MAX_CLIENT_ATTRIB_STACK_DEPTH
$0BB0	constant GL_ATTRIB_STACK_DEPTH
$0BB1	constant GL_CLIENT_ATTRIB_STACK_DEPTH
$0C22	constant GL_COLOR_CLEAR_VALUE
$0C23	constant GL_COLOR_WRITEMASK
$0B01	constant GL_CURRENT_INDEX
$0B00	constant GL_CURRENT_COLOR
$0B02	constant GL_CURRENT_NORMAL
$0B04	constant GL_CURRENT_RASTER_COLOR
$0B09	constant GL_CURRENT_RASTER_DISTANCE
$0B05	constant GL_CURRENT_RASTER_INDEX
$0B07	constant GL_CURRENT_RASTER_POSITION
$0B06	constant GL_CURRENT_RASTER_TEXTURE_COORDS
$0B08	constant GL_CURRENT_RASTER_POSITION_VALID
$0B03	constant GL_CURRENT_TEXTURE_COORDS
$0C20	constant GL_INDEX_CLEAR_VALUE
$0C30	constant GL_INDEX_MODE
$0C21	constant GL_INDEX_WRITEMASK
$0BA6	constant GL_MODELVIEW_MATRIX
$0BA3	constant GL_MODELVIEW_STACK_DEPTH
$0D70	constant GL_NAME_STACK_DEPTH
$0BA7	constant GL_PROJECTION_MATRIX
$0BA4	constant GL_PROJECTION_STACK_DEPTH
$0C40	constant GL_RENDER_MODE
$0C31	constant GL_RGBA_MODE
$0BA8	constant GL_TEXTURE_MATRIX
$0BA5	constant GL_TEXTURE_STACK_DEPTH
$0BA2	constant GL_VIEWPORT
$0D80	constant GL_AUTO_NORMAL
$0D90	constant GL_MAP1_COLOR_4
$0D91	constant GL_MAP1_INDEX
$0D92	constant GL_MAP1_NORMAL
$0D93	constant GL_MAP1_TEXTURE_COORD_1
$0D94	constant GL_MAP1_TEXTURE_COORD_2
$0D95	constant GL_MAP1_TEXTURE_COORD_3
$0D96	constant GL_MAP1_TEXTURE_COORD_4
$0D97	constant GL_MAP1_VERTEX_3
$0D98	constant GL_MAP1_VERTEX_4
$0DB0	constant GL_MAP2_COLOR_4
$0DB1	constant GL_MAP2_INDEX
$0DB2	constant GL_MAP2_NORMAL
$0DB3	constant GL_MAP2_TEXTURE_COORD_1
$0DB4	constant GL_MAP2_TEXTURE_COORD_2
$0DB5	constant GL_MAP2_TEXTURE_COORD_3
$0DB6	constant GL_MAP2_TEXTURE_COORD_4
$0DB7	constant GL_MAP2_VERTEX_3
$0DB8	constant GL_MAP2_VERTEX_4
$0DD0	constant GL_MAP1_GRID_DOMAIN
$0DD1	constant GL_MAP1_GRID_SEGMENTS
$0DD2	constant GL_MAP2_GRID_DOMAIN
$0DD3	constant GL_MAP2_GRID_SEGMENTS
$0A00	constant GL_COEFF
$0A01	constant GL_ORDER
$0A02	constant GL_DOMAIN
$0C50	constant GL_PERSPECTIVE_CORRECTION_HINT
$0C51	constant GL_POINT_SMOOTH_HINT
$0C52	constant GL_LINE_SMOOTH_HINT
$0C53	constant GL_POLYGON_SMOOTH_HINT
$0C54	constant GL_FOG_HINT
$1100	constant GL_DONT_CARE
$1101	constant GL_FASTEST
$1102	constant GL_NICEST
$0C10	constant GL_SCISSOR_BOX
$0C11	constant GL_SCISSOR_TEST
$0D10	constant GL_MAP_COLOR
$0D11	constant GL_MAP_STENCIL
$0D12	constant GL_INDEX_SHIFT
$0D13	constant GL_INDEX_OFFSET
$0D14	constant GL_RED_SCALE
$0D15	constant GL_RED_BIAS
$0D18	constant GL_GREEN_SCALE
$0D19	constant GL_GREEN_BIAS
$0D1A	constant GL_BLUE_SCALE
$0D1B	constant GL_BLUE_BIAS
$0D1C	constant GL_ALPHA_SCALE
$0D1D	constant GL_ALPHA_BIAS
$0D1E	constant GL_DEPTH_SCALE
$0D1F	constant GL_DEPTH_BIAS
$0CB1	constant GL_PIXEL_MAP_S_TO_S_SIZE
$0CB0	constant GL_PIXEL_MAP_I_TO_I_SIZE
$0CB2	constant GL_PIXEL_MAP_I_TO_R_SIZE
$0CB3	constant GL_PIXEL_MAP_I_TO_G_SIZE
$0CB4	constant GL_PIXEL_MAP_I_TO_B_SIZE
$0CB5	constant GL_PIXEL_MAP_I_TO_A_SIZE
$0CB6	constant GL_PIXEL_MAP_R_TO_R_SIZE
$0CB7	constant GL_PIXEL_MAP_G_TO_G_SIZE
$0CB8	constant GL_PIXEL_MAP_B_TO_B_SIZE
$0CB9	constant GL_PIXEL_MAP_A_TO_A_SIZE
$0C71	constant GL_PIXEL_MAP_S_TO_S
$0C70	constant GL_PIXEL_MAP_I_TO_I
$0C72	constant GL_PIXEL_MAP_I_TO_R
$0C73	constant GL_PIXEL_MAP_I_TO_G
$0C74	constant GL_PIXEL_MAP_I_TO_B
$0C75	constant GL_PIXEL_MAP_I_TO_A
$0C76	constant GL_PIXEL_MAP_R_TO_R
$0C77	constant GL_PIXEL_MAP_G_TO_G
$0C78	constant GL_PIXEL_MAP_B_TO_B
$0C79	constant GL_PIXEL_MAP_A_TO_A
$0D05	constant GL_PACK_ALIGNMENT
$0D01	constant GL_PACK_LSB_FIRST
$0D02	constant GL_PACK_ROW_LENGTH
$0D04	constant GL_PACK_SKIP_PIXELS
$0D03	constant GL_PACK_SKIP_ROWS
$0D00	constant GL_PACK_SWAP_BYTES
$0CF5	constant GL_UNPACK_ALIGNMENT
$0CF1	constant GL_UNPACK_LSB_FIRST
$0CF2	constant GL_UNPACK_ROW_LENGTH
$0CF4	constant GL_UNPACK_SKIP_PIXELS
$0CF3	constant GL_UNPACK_SKIP_ROWS
$0CF0	constant GL_UNPACK_SWAP_BYTES
$0D16	constant GL_ZOOM_X
$0D17	constant GL_ZOOM_Y
$2300	constant GL_TEXTURE_ENV
$2200	constant GL_TEXTURE_ENV_MODE
$0DE0	constant GL_TEXTURE_1D
$0DE1	constant GL_TEXTURE_2D
$2802	constant GL_TEXTURE_WRAP_S
$2803	constant GL_TEXTURE_WRAP_T
$2800	constant GL_TEXTURE_MAG_FILTER
$2801	constant GL_TEXTURE_MIN_FILTER
$2201	constant GL_TEXTURE_ENV_COLOR
$0C60	constant GL_TEXTURE_GEN_S
$0C61	constant GL_TEXTURE_GEN_T
$2500	constant GL_TEXTURE_GEN_MODE
$1004	constant GL_TEXTURE_BORDER_COLOR
$1000	constant GL_TEXTURE_WIDTH
$1001	constant GL_TEXTURE_HEIGHT
$1005	constant GL_TEXTURE_BORDER
$1003	constant GL_TEXTURE_COMPONENTS
$805C	constant GL_TEXTURE_RED_SIZE
$805D	constant GL_TEXTURE_GREEN_SIZE
$805E	constant GL_TEXTURE_BLUE_SIZE
$805F	constant GL_TEXTURE_ALPHA_SIZE
$8060	constant GL_TEXTURE_LUMINANCE_SIZE
$8061	constant GL_TEXTURE_INTENSITY_SIZE
$2700	constant GL_NEAREST_MIPMAP_NEAREST
$2702	constant GL_NEAREST_MIPMAP_LINEAR
$2701	constant GL_LINEAR_MIPMAP_NEAREST
$2703	constant GL_LINEAR_MIPMAP_LINEAR
$2401	constant GL_OBJECT_LINEAR
$2501	constant GL_OBJECT_PLANE
$2400	constant GL_EYE_LINEAR
$2502	constant GL_EYE_PLANE
$2402	constant GL_SPHERE_MAP
$2101	constant GL_DECAL
$2100	constant GL_MODULATE
$2600	constant GL_NEAREST
$2901	constant GL_REPEAT
$2900	constant GL_CLAMP
$2000	constant GL_S
$2001	constant GL_T
$2002	constant GL_R
$2003	constant GL_Q
$0C62	constant GL_TEXTURE_GEN_R
$0C63	constant GL_TEXTURE_GEN_Q
$1F00	constant GL_VENDOR
$1F01	constant GL_RENDERER
$1F02	constant GL_VERSION
$1F03	constant GL_EXTENSIONS
$0	constant GL_NO_ERROR
$0500	constant GL_INVALID_ENUM
$0501	constant GL_INVALID_VALUE
$0502	constant GL_INVALID_OPERATION
$0503	constant GL_STACK_OVERFLOW
$0504	constant GL_STACK_UNDERFLOW
$0505	constant GL_OUT_OF_MEMORY
$00000001	constant GL_CURRENT_BIT
$00000002	constant GL_POINT_BIT
$00000004	constant GL_LINE_BIT
$00000008	constant GL_POLYGON_BIT
$00000010	constant GL_POLYGON_STIPPLE_BIT
$00000020	constant GL_PIXEL_MODE_BIT
$00000040	constant GL_LIGHTING_BIT
$00000080	constant GL_FOG_BIT
$00000100	constant GL_DEPTH_BUFFER_BIT
$00000200	constant GL_ACCUM_BUFFER_BIT
$00000400	constant GL_STENCIL_BUFFER_BIT
$00000800	constant GL_VIEWPORT_BIT
$00001000	constant GL_TRANSFORM_BIT
$00002000	constant GL_ENABLE_BIT
$00004000	constant GL_COLOR_BUFFER_BIT
$00008000	constant GL_HINT_BIT
$00010000	constant GL_EVAL_BIT
$00020000	constant GL_LIST_BIT
$00040000	constant GL_TEXTURE_BIT
$00080000	constant GL_SCISSOR_BIT
$000FFFFF	constant GL_ALL_ATTRIB_BITS
$8063	constant GL_PROXY_TEXTURE_1D
$8064	constant GL_PROXY_TEXTURE_2D
$8066	constant GL_TEXTURE_PRIORITY
$8067	constant GL_TEXTURE_RESIDENT
$8068	constant GL_TEXTURE_BINDING_1D
$8069	constant GL_TEXTURE_BINDING_2D
$1003	constant GL_TEXTURE_INTERNAL_FORMAT
$803B	constant GL_ALPHA4
$803C	constant GL_ALPHA8
$803D	constant GL_ALPHA12
$803E	constant GL_ALPHA16
$803F	constant GL_LUMINANCE4
$8040	constant GL_LUMINANCE8
$8041	constant GL_LUMINANCE12
$8042	constant GL_LUMINANCE16
$8043	constant GL_LUMINANCE4_ALPHA4
$8044	constant GL_LUMINANCE6_ALPHA2
$8045	constant GL_LUMINANCE8_ALPHA8
$8046	constant GL_LUMINANCE12_ALPHA4
$8047	constant GL_LUMINANCE12_ALPHA12
$8048	constant GL_LUMINANCE16_ALPHA16
$8049	constant GL_INTENSITY
$804A	constant GL_INTENSITY4
$804B	constant GL_INTENSITY8
$804C	constant GL_INTENSITY12
$804D	constant GL_INTENSITY16
$2A10	constant GL_R3_G3_B2
$804F	constant GL_RGB4
$8050	constant GL_RGB5
$8051	constant GL_RGB8
$8052	constant GL_RGB10
$8053	constant GL_RGB12
$8054	constant GL_RGB16
$8055	constant GL_RGBA2
$8056	constant GL_RGBA4
$8057	constant GL_RGB5_A1
$8058	constant GL_RGBA8
$8059	constant GL_RGB10_A2
$805A	constant GL_RGBA12
$805B	constant GL_RGBA16
$00000001	constant GL_CLIENT_PIXEL_STORE_BIT
$00000002	constant GL_CLIENT_VERTEX_ARRAY_BIT
$FFFFFFFF	constant GL_ALL_CLIENT_ATTRIB_BITS
$FFFFFFFF	constant GL_CLIENT_ALL_ATTRIB_BITS
$803A	constant GL_RESCALE_NORMAL
$812F	constant GL_CLAMP_TO_EDGE
$80E8	constant GL_MAX_ELEMENTS_VERTICES
$80E9	constant GL_MAX_ELEMENTS_INDICES
$80E0	constant GL_BGR
$80E1	constant GL_BGRA
$8032	constant GL_UNSIGNED_BYTE_3_3_2
$8362	constant GL_UNSIGNED_BYTE_2_3_3_REV
$8363	constant GL_UNSIGNED_SHORT_5_6_5
$8364	constant GL_UNSIGNED_SHORT_5_6_5_REV
$8033	constant GL_UNSIGNED_SHORT_4_4_4_4
$8365	constant GL_UNSIGNED_SHORT_4_4_4_4_REV
$8034	constant GL_UNSIGNED_SHORT_5_5_5_1
$8366	constant GL_UNSIGNED_SHORT_1_5_5_5_REV
$8035	constant GL_UNSIGNED_INT_8_8_8_8
$8367	constant GL_UNSIGNED_INT_8_8_8_8_REV
$8036	constant GL_UNSIGNED_INT_10_10_10_2
$8368	constant GL_UNSIGNED_INT_2_10_10_10_REV
$81F8	constant GL_LIGHT_MODEL_COLOR_CONTROL
$81F9	constant GL_SINGLE_COLOR
$81FA	constant GL_SEPARATE_SPECULAR_COLOR
$813A	constant GL_TEXTURE_MIN_LOD
$813B	constant GL_TEXTURE_MAX_LOD
$813C	constant GL_TEXTURE_BASE_LEVEL
$813D	constant GL_TEXTURE_MAX_LEVEL
$0B12	constant GL_SMOOTH_POINT_SIZE_RANGE
$0B13	constant GL_SMOOTH_POINT_SIZE_GRANULARITY
$0B22	constant GL_SMOOTH_LINE_WIDTH_RANGE
$0B23	constant GL_SMOOTH_LINE_WIDTH_GRANULARITY
$846D	constant GL_ALIASED_POINT_SIZE_RANGE
$846E	constant GL_ALIASED_LINE_WIDTH_RANGE
$806B	constant GL_PACK_SKIP_IMAGES
$806C	constant GL_PACK_IMAGE_HEIGHT
$806D	constant GL_UNPACK_SKIP_IMAGES
$806E	constant GL_UNPACK_IMAGE_HEIGHT
$806F	constant GL_TEXTURE_3D
$8070	constant GL_PROXY_TEXTURE_3D
$8071	constant GL_TEXTURE_DEPTH
$8072	constant GL_TEXTURE_WRAP_R
$8073	constant GL_MAX_3D_TEXTURE_SIZE
$806A	constant GL_TEXTURE_BINDING_3D
$8001	constant GL_CONSTANT_COLOR
$8002	constant GL_ONE_MINUS_CONSTANT_COLOR
$8003	constant GL_CONSTANT_ALPHA
$8004	constant GL_ONE_MINUS_CONSTANT_ALPHA
$80D0	constant GL_COLOR_TABLE
$80D1	constant GL_POST_CONVOLUTION_COLOR_TABLE
$80D2	constant GL_POST_COLOR_MATRIX_COLOR_TABLE
$80D3	constant GL_PROXY_COLOR_TABLE
$80D4	constant GL_PROXY_POST_CONVOLUTION_COLOR_TABLE
$80D5	constant GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE
$80D6	constant GL_COLOR_TABLE_SCALE
$80D7	constant GL_COLOR_TABLE_BIAS
$80D8	constant GL_COLOR_TABLE_FORMAT
$80D9	constant GL_COLOR_TABLE_WIDTH
$80DA	constant GL_COLOR_TABLE_RED_SIZE
$80DB	constant GL_COLOR_TABLE_GREEN_SIZE
$80DC	constant GL_COLOR_TABLE_BLUE_SIZE
$80DD	constant GL_COLOR_TABLE_ALPHA_SIZE
$80DE	constant GL_COLOR_TABLE_LUMINANCE_SIZE
$80DF	constant GL_COLOR_TABLE_INTENSITY_SIZE
$8010	constant GL_CONVOLUTION_1D
$8011	constant GL_CONVOLUTION_2D
$8012	constant GL_SEPARABLE_2D
$8013	constant GL_CONVOLUTION_BORDER_MODE
$8014	constant GL_CONVOLUTION_FILTER_SCALE
$8015	constant GL_CONVOLUTION_FILTER_BIAS
$8016	constant GL_REDUCE
$8017	constant GL_CONVOLUTION_FORMAT
$8018	constant GL_CONVOLUTION_WIDTH
$8019	constant GL_CONVOLUTION_HEIGHT
$801A	constant GL_MAX_CONVOLUTION_WIDTH
$801B	constant GL_MAX_CONVOLUTION_HEIGHT
$801C	constant GL_POST_CONVOLUTION_RED_SCALE
$801D	constant GL_POST_CONVOLUTION_GREEN_SCALE
$801E	constant GL_POST_CONVOLUTION_BLUE_SCALE
$801F	constant GL_POST_CONVOLUTION_ALPHA_SCALE
$8020	constant GL_POST_CONVOLUTION_RED_BIAS
$8021	constant GL_POST_CONVOLUTION_GREEN_BIAS
$8022	constant GL_POST_CONVOLUTION_BLUE_BIAS
$8023	constant GL_POST_CONVOLUTION_ALPHA_BIAS
$8151	constant GL_CONSTANT_BORDER
$8153	constant GL_REPLICATE_BORDER
$8154	constant GL_CONVOLUTION_BORDER_COLOR
$80B1	constant GL_COLOR_MATRIX
$80B2	constant GL_COLOR_MATRIX_STACK_DEPTH
$80B3	constant GL_MAX_COLOR_MATRIX_STACK_DEPTH
$80B4	constant GL_POST_COLOR_MATRIX_RED_SCALE
$80B5	constant GL_POST_COLOR_MATRIX_GREEN_SCALE
$80B6	constant GL_POST_COLOR_MATRIX_BLUE_SCALE
$80B7	constant GL_POST_COLOR_MATRIX_ALPHA_SCALE
$80B8	constant GL_POST_COLOR_MATRIX_RED_BIAS
$80B9	constant GL_POST_COLOR_MATRIX_GREEN_BIAS
$80BA	constant GL_POST_COLOR_MATRIX_BLUE_BIAS
$80BB	constant GL_POST_COLOR_MATRIX_ALPHA_BIAS
$8024	constant GL_HISTOGRAM
$8025	constant GL_PROXY_HISTOGRAM
$8026	constant GL_HISTOGRAM_WIDTH
$8027	constant GL_HISTOGRAM_FORMAT
$8028	constant GL_HISTOGRAM_RED_SIZE
$8029	constant GL_HISTOGRAM_GREEN_SIZE
$802A	constant GL_HISTOGRAM_BLUE_SIZE
$802B	constant GL_HISTOGRAM_ALPHA_SIZE
$802C	constant GL_HISTOGRAM_LUMINANCE_SIZE
$802D	constant GL_HISTOGRAM_SINK
$802E	constant GL_MINMAX
$802F	constant GL_MINMAX_FORMAT
$8030	constant GL_MINMAX_SINK
$8031	constant GL_TABLE_TOO_LARGE
$8009	constant GL_BLEND_EQUATION
$8007	constant GL_MIN
$8008	constant GL_MAX
$8006	constant GL_FUNC_ADD
$800A	constant GL_FUNC_SUBTRACT
$800B	constant GL_FUNC_REVERSE_SUBTRACT
$8005	constant GL_BLEND_COLOR
$84C0	constant GL_TEXTURE0
$84C1	constant GL_TEXTURE1
$84C2	constant GL_TEXTURE2
$84C3	constant GL_TEXTURE3
$84C4	constant GL_TEXTURE4
$84C5	constant GL_TEXTURE5
$84C6	constant GL_TEXTURE6
$84C7	constant GL_TEXTURE7
$84C8	constant GL_TEXTURE8
$84C9	constant GL_TEXTURE9
$84CA	constant GL_TEXTURE10
$84CB	constant GL_TEXTURE11
$84CC	constant GL_TEXTURE12
$84CD	constant GL_TEXTURE13
$84CE	constant GL_TEXTURE14
$84CF	constant GL_TEXTURE15
$84D0	constant GL_TEXTURE16
$84D1	constant GL_TEXTURE17
$84D2	constant GL_TEXTURE18
$84D3	constant GL_TEXTURE19
$84D4	constant GL_TEXTURE20
$84D5	constant GL_TEXTURE21
$84D6	constant GL_TEXTURE22
$84D7	constant GL_TEXTURE23
$84D8	constant GL_TEXTURE24
$84D9	constant GL_TEXTURE25
$84DA	constant GL_TEXTURE26
$84DB	constant GL_TEXTURE27
$84DC	constant GL_TEXTURE28
$84DD	constant GL_TEXTURE29
$84DE	constant GL_TEXTURE30
$84DF	constant GL_TEXTURE31
$84E0	constant GL_ACTIVE_TEXTURE
$84E1	constant GL_CLIENT_ACTIVE_TEXTURE
$84E2	constant GL_MAX_TEXTURE_UNITS
$8511	constant GL_NORMAL_MAP
$8512	constant GL_REFLECTION_MAP
$8513	constant GL_TEXTURE_CUBE_MAP
$8514	constant GL_TEXTURE_BINDING_CUBE_MAP
$8515	constant GL_TEXTURE_CUBE_MAP_POSITIVE_X
$8516	constant GL_TEXTURE_CUBE_MAP_NEGATIVE_X
$8517	constant GL_TEXTURE_CUBE_MAP_POSITIVE_Y
$8518	constant GL_TEXTURE_CUBE_MAP_NEGATIVE_Y
$8519	constant GL_TEXTURE_CUBE_MAP_POSITIVE_Z
$851A	constant GL_TEXTURE_CUBE_MAP_NEGATIVE_Z
$851B	constant GL_PROXY_TEXTURE_CUBE_MAP
$851C	constant GL_MAX_CUBE_MAP_TEXTURE_SIZE
$84E9	constant GL_COMPRESSED_ALPHA
$84EA	constant GL_COMPRESSED_LUMINANCE
$84EB	constant GL_COMPRESSED_LUMINANCE_ALPHA
$84EC	constant GL_COMPRESSED_INTENSITY
$84ED	constant GL_COMPRESSED_RGB
$84EE	constant GL_COMPRESSED_RGBA
$84EF	constant GL_TEXTURE_COMPRESSION_HINT
$86A0	constant GL_TEXTURE_COMPRESSED_IMAGE_SIZE
$86A1	constant GL_TEXTURE_COMPRESSED
$86A2	constant GL_NUM_COMPRESSED_TEXTURE_FORMATS
$86A3	constant GL_COMPRESSED_TEXTURE_FORMATS
$809D	constant GL_MULTISAMPLE
$809E	constant GL_SAMPLE_ALPHA_TO_COVERAGE
$809F	constant GL_SAMPLE_ALPHA_TO_ONE
$80A0	constant GL_SAMPLE_COVERAGE
$80A8	constant GL_SAMPLE_BUFFERS
$80A9	constant GL_SAMPLES
$80AA	constant GL_SAMPLE_COVERAGE_VALUE
$80AB	constant GL_SAMPLE_COVERAGE_INVERT
$20000000	constant GL_MULTISAMPLE_BIT
$84E3	constant GL_TRANSPOSE_MODELVIEW_MATRIX
$84E4	constant GL_TRANSPOSE_PROJECTION_MATRIX
$84E5	constant GL_TRANSPOSE_TEXTURE_MATRIX
$84E6	constant GL_TRANSPOSE_COLOR_MATRIX
$8570	constant GL_COMBINE
$8571	constant GL_COMBINE_RGB
$8572	constant GL_COMBINE_ALPHA
$8580	constant GL_SOURCE0_RGB
$8581	constant GL_SOURCE1_RGB
$8582	constant GL_SOURCE2_RGB
$8588	constant GL_SOURCE0_ALPHA
$8589	constant GL_SOURCE1_ALPHA
$858A	constant GL_SOURCE2_ALPHA
$8590	constant GL_OPERAND0_RGB
$8591	constant GL_OPERAND1_RGB
$8592	constant GL_OPERAND2_RGB
$8598	constant GL_OPERAND0_ALPHA
$8599	constant GL_OPERAND1_ALPHA
$859A	constant GL_OPERAND2_ALPHA
$8573	constant GL_RGB_SCALE
$8574	constant GL_ADD_SIGNED
$8575	constant GL_INTERPOLATE
$84E7	constant GL_SUBTRACT
$8576	constant GL_CONSTANT
$8577	constant GL_PRIMARY_COLOR
$8578	constant GL_PREVIOUS
$86AE	constant GL_DOT3_RGB
$86AF	constant GL_DOT3_RGBA
$812D	constant GL_CLAMP_TO_BORDER
1	constant GL_ARB_multitexture
$84C0	constant GL_TEXTURE0_ARB
$84C1	constant GL_TEXTURE1_ARB
$84C2	constant GL_TEXTURE2_ARB
$84C3	constant GL_TEXTURE3_ARB
$84C4	constant GL_TEXTURE4_ARB
$84C5	constant GL_TEXTURE5_ARB
$84C6	constant GL_TEXTURE6_ARB
$84C7	constant GL_TEXTURE7_ARB
$84C8	constant GL_TEXTURE8_ARB
$84C9	constant GL_TEXTURE9_ARB
$84CA	constant GL_TEXTURE10_ARB
$84CB	constant GL_TEXTURE11_ARB
$84CC	constant GL_TEXTURE12_ARB
$84CD	constant GL_TEXTURE13_ARB
$84CE	constant GL_TEXTURE14_ARB
$84CF	constant GL_TEXTURE15_ARB
$84D0	constant GL_TEXTURE16_ARB
$84D1	constant GL_TEXTURE17_ARB
$84D2	constant GL_TEXTURE18_ARB
$84D3	constant GL_TEXTURE19_ARB
$84D4	constant GL_TEXTURE20_ARB
$84D5	constant GL_TEXTURE21_ARB
$84D6	constant GL_TEXTURE22_ARB
$84D7	constant GL_TEXTURE23_ARB
$84D8	constant GL_TEXTURE24_ARB
$84D9	constant GL_TEXTURE25_ARB
$84DA	constant GL_TEXTURE26_ARB
$84DB	constant GL_TEXTURE27_ARB
$84DC	constant GL_TEXTURE28_ARB
$84DD	constant GL_TEXTURE29_ARB
$84DE	constant GL_TEXTURE30_ARB
$84DF	constant GL_TEXTURE31_ARB
$84E0	constant GL_ACTIVE_TEXTURE_ARB
$84E1	constant GL_CLIENT_ACTIVE_TEXTURE_ARB
$84E2	constant GL_MAX_TEXTURE_UNITS_ARB
1	constant GL_MESA_shader_debug
$8759	constant GL_DEBUG_OBJECT_MESA
$875A	constant GL_DEBUG_PRINT_MESA
$875B	constant GL_DEBUG_ASSERT_MESA
1	constant GL_MESA_trace
$FFFF	constant GL_TRACE_ALL_BITS_MESA
$0001	constant GL_TRACE_OPERATIONS_BIT_MESA
$0002	constant GL_TRACE_PRIMITIVES_BIT_MESA
$0004	constant GL_TRACE_ARRAYS_BIT_MESA
$0008	constant GL_TRACE_TEXTURES_BIT_MESA
$0010	constant GL_TRACE_PIXELS_BIT_MESA
$0020	constant GL_TRACE_ERRORS_BIT_MESA
$8755	constant GL_TRACE_MASK_MESA
$8756	constant GL_TRACE_NAME_MESA
1	constant GL_MESA_packed_depth_stencil
$8750	constant GL_DEPTH_STENCIL_MESA
$8751	constant GL_UNSIGNED_INT_24_8_MESA
$8752	constant GL_UNSIGNED_INT_8_24_REV_MESA
$8753	constant GL_UNSIGNED_SHORT_15_1_MESA
$8754	constant GL_UNSIGNED_SHORT_1_15_REV_MESA
1	constant GL_MESA_program_debug
$8bb0	constant GL_FRAGMENT_PROGRAM_POSITION_MESA
$8bb1	constant GL_FRAGMENT_PROGRAM_CALLBACK_MESA
$8bb2	constant GL_FRAGMENT_PROGRAM_CALLBACK_FUNC_MESA
$8bb3	constant GL_FRAGMENT_PROGRAM_CALLBACK_DATA_MESA
$8bb4	constant GL_VERTEX_PROGRAM_POSITION_MESA
$8bb5	constant GL_VERTEX_PROGRAM_CALLBACK_MESA
$8bb6	constant GL_VERTEX_PROGRAM_CALLBACK_FUNC_MESA
$8bb7	constant GL_VERTEX_PROGRAM_CALLBACK_DATA_MESA
1	constant GL_ATI_blend_equation_separate
$883D	constant GL_ALPHA_BLEND_EQUATION_ATI

